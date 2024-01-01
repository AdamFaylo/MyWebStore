﻿using API.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Policy;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepo;
        private readonly IColorsRepository _colorsRepo;
        private readonly IUserRepository _userRepo;
        private readonly IGalleryImageRepository _galleryImageRepo;
        private readonly ISizeRepository _sizeRepo;
        private readonly IDepartmentRepository _departmentRepo;



        public ProductController(
            IProductRepository productRepo,
            IUserRepository userRepo,
            ILogger<ProductController> logger,
            IColorsRepository colorsRepo,
            IGalleryImageRepository galleryImageRepo,
            ISizeRepository sizeRepo,
            IDepartmentRepository departmentRepo
        )
        {
            this._userRepo = userRepo;
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this._productRepo = productRepo ?? throw new ArgumentNullException(nameof(productRepo));
            this._colorsRepo = colorsRepo ?? throw new ArgumentNullException(nameof(colorsRepo));
            this._galleryImageRepo = galleryImageRepo ?? throw new ArgumentNullException(nameof(galleryImageRepo));
            this._sizeRepo = sizeRepo ?? throw new ArgumentNullException(nameof(sizeRepo));
            this._departmentRepo = departmentRepo ?? throw new ArgumentNullException(nameof(departmentRepo));
        }


        [HttpGet]
        public IActionResult GetAllProduct()
        {
            try
            {
                var result = _productRepo.FindAll().Include(p => p.GalleryImage).ToList();
                return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "An error occurred while creating the item.");

                return StatusCode(500, new
                {
                    Message = "An error occurred while creating the item.",
                    ExceptionMessage = ex.Message,
                    InnerExceptionMessage = ex.InnerException?.Message, // Include inner exception message
                    StackTrace = ex.StackTrace
                });
            }
        }

        [HttpGet("{id:int}")]

        public IActionResult GetByIDProduct(int id)
        {
            try
            {
                var product = _productRepo.FindByCondition(p => p.ID == id)
                    .Include(g => g.GalleryImage)
                    .Include(d => d.Department)
                    .Include(s => s.SubCategory)
                    .ThenInclude(c => c.Category)
                    .Include(p => p.Colors)
                    .Include(p => p.Size)

                    .FirstOrDefault();
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "An error occurred while creating the item.");

                return StatusCode(500, new
                {
                    Message = "An error occurred while creating the item.",
                    ExceptionMessage = ex.Message,
                    InnerExceptionMessage = ex.InnerException?.Message, // Include inner exception message
                    StackTrace = ex.StackTrace
                });
            }

        }
        [HttpPost]
        public IActionResult CreateProduct(ProductDTO item)
        {
            try
            {
                var token = Request.Headers["Authorization"];
                token = token.ToString().Split("Bearer ")[1];
                var decodedToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
                var userId = decodedToken.Claims.First().Value;
                var user = _userRepo.FindByCondition(user => user.ID == int.Parse(userId)).Include(u => u.Cart)
                    .ThenInclude(cart => cart.OrderItems)
                    .ThenInclude(orderItems => orderItems.Product)
                    .ThenInclude(item => item.GalleryImage)
                    .FirstOrDefault();

                if (user is null || user.Type != MyProject.API.Models.Enums.UserType.Admin)
                {
                    return Unauthorized();
                }

                if (item == null)
                {
                    _logger.LogDebug("Item is null.");
                    return BadRequest();
                }

                var newItem = new Product()
                {
                    ProductName = item.Name,
                    Price = item.Price,
                    Description = item.Description,
                    SubCategoryID = item.SubCategoryID,
                    DepartmentID = item.DepartmentID, // Set the DepartmentID based on user's selection
                    AddedOn = DateTime.UtcNow,
                };

                // Check if the DepartmentID is valid by querying your Departments table
                var department = _departmentRepo.FindByCondition(d => d.ID == newItem.DepartmentID).FirstOrDefault();
                if (department == null)
                {
                    // Return a 400 Bad Request with a meaningful error message
                    return BadRequest("Invalid DepartmentID. Department does not exist.");
                }

                var result = _productRepo.Create(newItem);
                return Created("user", result);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                _logger.LogCritical(ex, "An error occurred while creating the item.");

                return StatusCode(500, new
                {
                    Message = "An error occurred while creating the item.",
                    ExceptionMessage = ex.Message,
                    InnerExceptionMessage = ex.InnerException?.Message,
                    StackTrace = ex.StackTrace
                });
            }
        }

        [HttpPut]
        public IActionResult Update(int id, [FromBody] ProductDTO productDto)
        {
            if (productDto == null)
            {
                return BadRequest("Invalid product data.");
            }

            var product = _productRepo.FindByCondition(p => p.ID == id)
                .Include(p => p.GalleryImage) // Include the GalleryImage
                .FirstOrDefault();

            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }

            // Update product properties here
            product.ProductName = productDto.Name;
            product.Price = productDto.Price;
            // ... additional property updates ...

            // Update GalleryImage properties if needed
            foreach (var galleryImageDto in productDto.GalleryImage)
            {
                var galleryImage = product.GalleryImage.FirstOrDefault(g => g.ID == galleryImageDto.ID);
                if (galleryImage != null)
                {
                    galleryImage.Title = galleryImageDto.Title;
                    galleryImage.ImageURL = galleryImageDto.ImageURL;
                    galleryImage.Alt = galleryImageDto.Alt;
                    // ... additional gallery image property updates ...
                }
            }

            try
            {
                _productRepo.Update(product);
                _productRepo.Save();
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating product with ID {ProductId}", product.ID);
                return StatusCode(500, "An error occurred while updating the product.");
            }
        }




        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var product = _productRepo.FindByCondition(p => p.ID == id).FirstOrDefault();
                if (product == null)
                {
                    return NoContent();
                }
                _productRepo.Delete(product);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "An error occurred while creating the item.");

                return StatusCode(500, new
                {
                    Message = "An error occurred while creating the item.",
                    ExceptionMessage = ex.Message,
                    InnerExceptionMessage = ex.InnerException?.Message, // Include inner exception message
                    StackTrace = ex.StackTrace
                });
            }
        }

    }
}
