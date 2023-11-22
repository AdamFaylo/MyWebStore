using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Models.DTO;
using MyProject.API.Repositories.Abstract;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SizeController : Controller
    {
        private readonly ISizeRepository _sizeRepository;
        private readonly ILogger<SizeController> _logger;

        public SizeController(
            ISizeRepository _sizeRepository,
            ILogger<SizeController> _logger
            )
        {
            this._sizeRepository = _sizeRepository ?? throw new ArgumentNullException(nameof(_sizeRepository));
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
        }

        [HttpGet]
        public IActionResult GetAllSize()
        {
            try
            {
                var result = _sizeRepository.FindAll().ToList();
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
        public IActionResult GetSizeByID(int id)
        {

            try
            {
                var result = _sizeRepository.FindByCondition(s => s.ID == id).FirstOrDefault();
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
        public IActionResult CreateSize(SizeDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }
                var newItem = new Size()
                {
                    ID = item.ID,
                    SizeName = item.SizeName,
                    ProductID = item.ProductID,
                 
                };

                var result = _sizeRepository.Create(newItem);
                return Created("size", result);
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
        public IActionResult UpdateSize(SizeDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }
                var current = _sizeRepository.FindByCondition(p => p.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }
    
                var updateSize = _sizeRepository.Update(current);
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
        public IActionResult DeleteSize(int id)
        {
            try
            {
                var findSizeID = _sizeRepository.FindByCondition(s => s.ID == id).FirstOrDefault();
                if (findSizeID == null)
                {
                    NoContent();
                }
                _sizeRepository.Delete(findSizeID);
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

