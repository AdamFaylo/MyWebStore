using API.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubCategoryController : Controller
    {
        private readonly IProductRepository _productRepo;
        private readonly ILogger<SubCategoryController> _logger;
        private readonly ISubCategoryRepository _subCategoryRepo;

        public SubCategoryController(
            ISubCategoryRepository _subCategoryRepo,
            IProductRepository _productRepo,
            ILogger<SubCategoryController> _logger
            )
        {
            this._productRepo = _productRepo ?? throw new ArgumentNullException(nameof(_productRepo));
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._subCategoryRepo = _subCategoryRepo ?? throw new ArgumentNullException(nameof(_subCategoryRepo));
        }

        [HttpGet]
        public IActionResult GetAllSubCategory()
        {
            try
            {
                var result = _subCategoryRepo.FindAll().ToList();
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
        public IActionResult GetSubCategoryById(int id)
        {
            try
            {
                var result = _subCategoryRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
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

        [HttpPost("CreateSubCategory")]
        public IActionResult CreateSubCategory(SubCategoryDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }

                List<Product> products = new List<Product>();
                foreach (var productID in item.Products)
                {
                    var product = _productRepo.FindByCondition(o => o.ID == productID).FirstOrDefault();
                    if (product == null)
                    {
                        continue;
                    }
                    products.Add(product);
                }

                var newItem = new SubCategory()
                {
                    ID = item.ID,
                   
                    SubCategoryName = item.SubCategoryName,
                    
                };

                var result = _subCategoryRepo.Create(newItem);
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
        public IActionResult UpdateSubCategory(SubCategoryDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }

                var current = _subCategoryRepo.FindByCondition(u => u.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }
                current.ID = item.ID;
                current.SubCategoryName = item.SubCategoryName;
             

                _subCategoryRepo.Update(current);

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
        public IActionResult DeleteSubCategory(int id)
        {
            try
            {
                var result = _subCategoryRepo.FindByCondition(s => s.ID == id).FirstOrDefault();
                if (result == null)
                {
                    return NotFound();
                }
                _subCategoryRepo.Delete(result);
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
