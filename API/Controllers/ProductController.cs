using API.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepo;
        private readonly IColorsRepository _colorsRepo;
        private readonly IGalleryImageRepository _galleryImageRepo;
        private readonly ISizeRepository _sizeRepo;


        public ProductController(
            IProductRepository _productRepo,
            ILogger<ProductController> _logger,
            IColorsRepository _colorsRepo,
            IGalleryImageRepository _galleryImageRepo,
            ISizeRepository _sizeRepo

            )
        {
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._productRepo = _productRepo ?? throw new ArgumentNullException(nameof(_productRepo));
            this._colorsRepo = _colorsRepo ?? throw new ArgumentNullException(nameof(_colorsRepo));
            this._galleryImageRepo = _galleryImageRepo ?? throw new ArgumentNullException(nameof(_galleryImageRepo));
            this._sizeRepo = _sizeRepo ?? throw new ArgumentNullException(nameof(_sizeRepo));

        }

        [HttpGet]
        //[Authorize]
        //[Route("GetAllProduct")]
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
                var result = _productRepo.FindByCondition(p => p.ID == id).FirstOrDefault();
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

        [HttpPost]
        public IActionResult CreateProduct(ProductDTO item)
        {
            try
            {
                var user = (User?)HttpContext.Items["User"];
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
                    ID = item.ID,
                    ProductName = item.Name,
                    Price = item.Price,
                    SubCategoryID = item.DepartmentID,
                    DepartmentID = item.DepartmentID,

                };

                var result = _productRepo.Create(newItem);
                return Created("user", result);
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

        [HttpPut]
        public IActionResult Update(ProductDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }

                var current = _productRepo.FindByCondition(p => p.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }
                current.ID = item.ID;
                current.ProductName = item.Name;
                current.Colors = new List<Color>();
                current.GalleryImage = new List<GalleryImage>();
                current.Size = new List<Size>();


                //foreach (int colorID in item.Colors)
                //{
                //    if (current.Colors.Any(s => s.ID == colorID))
                //    {
                //        continue;
                //    }
                //    var newColors = _colorsRepo.FindByCondition(s => s.ID == colorID).FirstOrDefault();
                //    if (newColors == null)
                //    {
                //        continue;
                //    }
                //    current.Colors.Add(newColors);
                //}

                //List<Color> colorsToRemove = new List<Color>();
                //foreach (var color in current.Colors)
                //{
                //    if (item.Colors.Contains(color.ID))
                //    {
                //        continue;
                //    }
                //    colorsToRemove.Add(color);
                //}
                //foreach (var color in colorsToRemove)
                //{
                //    current.Colors.Remove(color);
                //}

                _productRepo.Update(current);

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
