using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace MyProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogoImageController : Controller
    {
        private readonly ILogger<LogoImageController> _logger;
        private readonly ILogoImageRepository _logoImageRepo;

        public LogoImageController(
            ILogoImageRepository _logoImageRepo,
            ILogger<LogoImageController> _logger
            )
        {
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._logoImageRepo = _logoImageRepo ?? throw new ArgumentNullException(nameof(_logoImageRepo));
        }

        [HttpGet]
        public IActionResult GetLogo()
        {
            try
            {
                var result = _logoImageRepo.FindAll().ToList();
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

        [HttpPut]
        public IActionResult UpdateImage(LogoImage item)
        {
            try
            {
                if (item == null)
                {
                    NoContent();
                }

                var result = _logoImageRepo.Update(item);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"{ex.Message}", ex);
                return StatusCode(500, new { });
            }
        }
    }
}
