using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace MyProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ICustomerRepository _CustomerRepo;
        private readonly IOrderRepository _orderRepo;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(
            IConfiguration _config,
            ICustomerRepository _CustomerRepo,
            IOrderRepository _orderRepo,
            ILogger<CustomerController> _logger
            )
        {
            this._config = _config ?? throw new ArgumentNullException(nameof(_config));
            this._CustomerRepo = _CustomerRepo ?? throw new ArgumentNullException(nameof(_CustomerRepo));
            this._orderRepo = _orderRepo ?? throw new ArgumentNullException(nameof(_orderRepo));
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
        }

        [HttpGet]
        public IActionResult GetAllCustomer()
        {
            try
            {
                var result = _CustomerRepo.FindAll().ToList();
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
        public IActionResult GetByIdCustomer(int id)
        {
            try
            {
                var result = _CustomerRepo.FindByCondition(c => c.ID == id).ToList();
                return Ok(result);
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

        [HttpPost]
        public IActionResult CreateCustomer(Models.DTO.CustomerDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }
                List<Order> orders = new List<Order>();


                var newItem = new Customer()
                {
                    ID = item.ID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Mail = item.Mail,
                    Order = orders
                };

                var result = _CustomerRepo.Create(newItem);
                return Created("customer", result);
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

        [HttpPut]
        public IActionResult UpdateCustomer(Models.DTO.CustomerDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }

                var current = _CustomerRepo.FindByCondition(u => u.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }
                current.ID = item.ID;
                current.FirstName = item.FirstName;
                current.LastName = item.LastName;
                current.Mail = item.Mail;
                current.Order = new List<Order>();

                foreach (int orderID in item.Order)
                {
                    if (current.Order.Any(s => s.OrderId == orderID))
                    {
                        continue;
                    }
                    var newSkill = _orderRepo.FindByCondition(s => s.OrderId == orderID).FirstOrDefault();
                    if (newSkill == null)
                    {
                        continue;
                    }
                    current.Order.Add(newSkill);
                }

                List<Order> orderToRemove = new List<Order>();
                foreach (var order in current.Order)
                {
                    if (item.Order.Contains(order.OrderId))
                    {
                        continue;
                    }
                    orderToRemove.Add(order);
                }
                foreach (var order in orderToRemove)
                {
                    current.Order.Remove(order);
                }

                _CustomerRepo.Update(current);

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

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _CustomerRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
                if (result == null)
                {
                    return NotFound();

                }
                _CustomerRepo.Delete(result);
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
