using API.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;
using System.Drawing;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorController : Controller
    {
        private readonly ILogger<ColorController> _logger;
        private readonly IColorsRepository _colorsRepo;

        public ColorController(
            IColorsRepository _colorsRepo,
            ILogger<ColorController> _logger
            )
        {
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._colorsRepo = _colorsRepo ?? throw new ArgumentNullException(nameof(_colorsRepo));
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
                var result = _colorsRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
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
        public IActionResult CreateColor(ColorDTO color)
        {
            try
            {
                if (color == null)
                {
                    return BadRequest("Invalid item data.");
                }
                var newItem = new MyProject.API.Models.Color()
                {

                    Name = color.Name,
                    ProductID = color.ProductID,
                };
                var createdItem = _colorsRepo.Create(newItem);
                return Created("user", createdItem);
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
        public IActionResult UpdateColors(ColorDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }
                var current = _colorsRepo.FindByCondition(p => p.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }

                var updateSize = _colorsRepo.Update(current);
                return Ok(updateSize);
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
        public IActionResult DeleteColor(int id)
        {
            try
            {
                var color = _colorsRepo.FindByCondition(_ => _.ID == id).FirstOrDefault();
                if (color == null)
                {
                    return NoContent();
                }
                _colorsRepo.Delete(color);
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
