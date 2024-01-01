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
        private readonly ICategoryRepository _categoryRepo;
        private readonly ISubCategoryRepository _subCategoryRepo;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(
            ICategoryRepository categoryRepo,
            ISubCategoryRepository subCategoryRepo,
            ILogger<CategoryController> logger
        )
        {
            _categoryRepo = categoryRepo ?? throw new ArgumentNullException(nameof(categoryRepo));
            _subCategoryRepo = subCategoryRepo ?? throw new ArgumentNullException(nameof(subCategoryRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult GetAllCategory()
        {
            try
            {
                var categories = _categoryRepo.FindAll().ToList();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching all categories.");
                return StatusCode(500, "An error occurred while fetching all categories.");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            try
            {
                var category = _categoryRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
                if (category == null)
                {
                    return NotFound();
                }
                return Ok(category);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the category.");
                return StatusCode(500, "An error occurred while fetching the category.");
            }
        }

        [HttpPost]
        public IActionResult CreateCategory(CategoryDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest("Category data is required.");
                }

                var newCategory = new Category
                {
                    Name = item.Name
                    // SubCategories can be assigned here if necessary
                };

                _categoryRepo.Create(newCategory);
                return CreatedAtAction(nameof(GetByID), new { id = newCategory.ID }, newCategory);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the category.");
                return StatusCode(500, "An error occurred while creating the category.");
            }
        }

        [HttpPut]
        public IActionResult UpdateCategory(CategoryDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest("Category data is required.");
                }

                var category = _categoryRepo.FindByCondition(c => c.ID == item.ID).FirstOrDefault();
                if (category == null)
                {
                    return NotFound();
                }

                category.Name = item.Name;
                // Update subcategories here if necessary

                _categoryRepo.Update(category);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the category.");
                return StatusCode(500, "An error occurred while updating the category.");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                var category = _categoryRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
                if (category == null)
                {
                    return NotFound();
                }

                _categoryRepo.Delete(category);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the category.");
                return StatusCode(500, "An error occurred while deleting the category.");
            }
        }
    }
}
