using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Models.DTO;
using MyProject.API.Repositories.Abstract;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GalleryImageController : Controller
    {
        private readonly ILogger<GalleryImageController> _logger;
        private readonly IGalleryImageRepository _galleryImageRepo;

        public GalleryImageController(
            IGalleryImageRepository _galleryImageRepo,
            ILogger<GalleryImageController> _logger
            )
        {
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._galleryImageRepo = _galleryImageRepo ?? throw new ArgumentNullException(nameof(_galleryImageRepo));
        }

        [HttpGet]
        public IActionResult Get(string imageName)
        {
            return PhysicalFile(@$"E:\\productImages\{imageName}.jpg", "image/jpeg");
        }

        [HttpGet("{id:int}")]
        public IActionResult GetByIdGalleryImage(int id)
        {
            try
            {
                var result = _galleryImageRepo.FindByCondition(g => g.ID == id).FirstOrDefault();
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
        public IActionResult CreateGalleryImage(GalleryImageDTO image)
        {
            try
            {
                if (image == null)
                {
                    return BadRequest("don`t have image");
                }

                var newItem = new GalleryImage()
                {
                    
                    Title = image.Title,
                    ImageURL = image.ImageURL,
                    Alt = image.Alt,
                    ProductID = image.ProductID,

                };
                var result = _galleryImageRepo.Create(newItem);
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
        public IActionResult UpdateGalleryImage(GalleryImageDTO image)
        {
            try
            {
                if (image == null)
                {
                    return BadRequest();
                }

                var current = _galleryImageRepo.FindByCondition(u => u.ID == image.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }
                current.ID = image.ID;
                current.Title = image.Title;
                current.ImageURL = image.ImageURL;
                current.Alt = image.Alt;

                _galleryImageRepo.Update(current);

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
        public IActionResult DeleteGalleryImage(int id)
        {
            try
            {
                var galleryImage = _galleryImageRepo.FindByCondition(g => g.ID == id).FirstOrDefault();
                if (galleryImage == null)
                {
                    return NoContent();
                }
                _galleryImageRepo.Delete(galleryImage);
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
