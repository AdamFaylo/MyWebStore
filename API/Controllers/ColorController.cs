using API.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;
using System;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorController : Controller
    {
        private readonly ILogger<ColorController> _logger;
        private readonly IColorsRepository _colorsRepo;

        public ColorController(
            IColorsRepository colorsRepo,
            ILogger<ColorController> logger
            )
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _colorsRepo = colorsRepo ?? throw new ArgumentNullException(nameof(colorsRepo));
        }

        [HttpGet]
        public IActionResult GetAllColor()
        {
            try
            {
                var result = _colorsRepo.FindAll().ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching all colors.");
                return StatusCode(500, "An error occurred while fetching all colors.");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            try
            {
                var result = _colorsRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the color.");
                return StatusCode(500, "An error occurred while fetching the color.");
            }
        }

        [HttpPost]
        public IActionResult CreateColor(ColorDTO color)
        {
            try
            {
                if (color == null)
                {
                    return BadRequest("Color data is required.");
                }

                var newItem = new MyProject.API.Models.Color
                {
                    Name = color.Name,
                    ProductID = color.ProductID
                };

                var createdItem = _colorsRepo.Create(newItem);
                return CreatedAtAction(nameof(GetByID), new { id = createdItem.Id }, createdItem);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the color.");
                return StatusCode(500, "An error occurred while creating the color.");
            }
        }

        [HttpPut]
        public IActionResult UpdateColors(ColorDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest("Color data is required.");
                }

                var currentColor = _colorsRepo.FindByCondition(c => c.ID == item.ID).FirstOrDefault();
                if (currentColor == null)
                {
                    return NotFound();
                }

                currentColor.Name = item.Name;
                // Update other properties as needed

                _colorsRepo.Update(currentColor);
                return Ok(currentColor);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the color.");
                return StatusCode(500, "An error occurred while updating the color.");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteColor(int id)
        {
            try
            {
                var color = _colorsRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
                if (color == null)
                {
                    return NotFound();
                }

                _colorsRepo.Delete(color);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the color.");
                return StatusCode(500, "An error occurred while deleting the color.");
            }
        }
    }
}
