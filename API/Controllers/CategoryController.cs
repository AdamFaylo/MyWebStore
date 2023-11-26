using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Models.DTO;
using MyProject.API.Repositories.Abstract;

namespace MyProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ICategoryRepository _categoryRepo;
        private readonly ILogger<CategoryController> _logger;
        private readonly ISubCategoryRepository _subCategoryRepo;

        public CategoryController(
            IConfiguration _config,
            ICategoryRepository _categoryRepo,
            ISubCategoryRepository _subCategoryRepo,
            ILogger<CategoryController> _logger
            )
        {
            this._categoryRepo = _categoryRepo ?? throw new ArgumentNullException(nameof(_categoryRepo));
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._subCategoryRepo = _subCategoryRepo ?? throw new ArgumentNullException(nameof(_subCategoryRepo));
            this._config = _config ?? throw new ArgumentNullException(nameof(_config));

        }

        [HttpGet]
        public IActionResult GetAllCategory()
        {
            try
            {

                var result = _categoryRepo.FindAll().ToList();
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
        public IActionResult GetByID(int id)
        {
            try
            {
                var result = _categoryRepo.FindByCondition(c => c.ID == id).ToList();
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
        public IActionResult CreateCategory(CategoryDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }
                List<SubCategory> subCategories = new List<SubCategory>();
      

                var newItem = new Category()
                {
                    ID = item.ID,
                    Name = item.Name,
                    SubCategories = subCategories
                };

                var result = _categoryRepo.Create(newItem);
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
        public IActionResult UpdateCategory(Models.DTO.CategoryDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }

                var current = _categoryRepo.FindByCondition(u => u.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }
                current.ID = item.ID;
                current.Name = item.Name;
                current.SubCategories = new List<SubCategory>();

                foreach (int subCategoriesID in item.SubCategories)
                {
                    if (current.SubCategories.Any(s => s.ID == subCategoriesID))
                    {
                        continue;
                    }
                    var newSubCategory = _subCategoryRepo.FindByCondition(s => s.ID == subCategoriesID).FirstOrDefault();
                    if (newSubCategory == null)
                    {
                        continue;
                    }
                    current.SubCategories.Add(newSubCategory);
                }

                List<SubCategory> subCategoryToRemove = new List<SubCategory>();
                foreach (var subCategory in current.SubCategories)
                {
                    if (item.SubCategories.Contains(subCategory.ID))
                    {
                        continue;
                    }
                    subCategoryToRemove.Add(subCategory);
                }
                foreach (var order in subCategoryToRemove)
                {
                    current.SubCategories.Remove(order);
                }

                _categoryRepo.Update(current);

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
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                var result = _categoryRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
                if (result == null)
                {
                    return NotFound();
                }
                _categoryRepo.Delete(result);
                return NoContent();
            }
            catch (Exception ex)
            {
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
    }
}
