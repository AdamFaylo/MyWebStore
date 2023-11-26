using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace MyProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        private readonly ILogger _logger;
        private readonly ICartRepository _cardsRepo;

        public CartController(
            ICartRepository _cardsRepo,
            ILogger _logger
            )
        {
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._cardsRepo = _cardsRepo ?? throw new ArgumentNullException(nameof (_cardsRepo));
        }
        [HttpGet]
        public IActionResult GetCarts()
        {
            try
            {
                var result = _cardsRepo.FindAll().ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "");
                return StatusCode(500, new
                {
                    Message = "An error occurred while creating the item.",
                    ExceptionMessage = ex.Message,
                    InnerExceptionMessage = ex.InnerException?.Message, 
                    StackTrace = ex.StackTrace
                });
            }
               
        }

        //[HttpGet("{id:int}")]
        //public IActionResult GetCartByID(int id) {
        //    var result = _cardsRepo.FindByCondition(c=>c.CartID == id).FirstOrDefault();
        //    return Ok(result);
        //}

        //[HttpPost]
        //public IActionResult CreateCart(Cart item)
        //{
        //    try
        //    {
        //        if (item == null)
        //        {
        //            return BadRequest();
        //        }
        //        var result = _cardsRepo.Create(item);
        //        return Created("cart", result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogCritical(ex, "An error occurred while creating the item.");
        //        return StatusCode(500, new {
        //            Message = "An error occurred while creating the item.",
        //            ExceptionMessage = ex.Message,
        //            InnerExceptionMessage = ex.InnerException?.Message,
        //            StackTrace = ex.StackTrace
        //        });  
        //    }
            
        //}

        //[HttpPut]
        //public IActionResult UpdateCart(Cart item)
        //{
        //    if (item == null)
        //    {
        //        return BadRequest();
        //    }

        //}
    }
}
