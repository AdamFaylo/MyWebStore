using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyProject.API.Models;
using MyProject.API.Models.DTO;
using MyProject.API.Repositories.Abstract;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingAddressController : Controller
    {
        private readonly ILogger<ShippingAddressController> _logger;
        private readonly IShippingAddressRepository _shippingAddressRepo;
        private readonly IOrderRepository _orderRepo;

        public ShippingAddressController(
            IShippingAddressRepository _shippingAddressRepo,
            IOrderRepository _orderRepo,
            ILogger<ShippingAddressController> _logger
            )
        {
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._shippingAddressRepo = _shippingAddressRepo ?? throw new ArgumentNullException(nameof(_shippingAddressRepo));
            this._orderRepo = _orderRepo ?? throw new ArgumentNullException(nameof(_orderRepo));
        }

        [HttpGet]
        public IActionResult GetAllShippingAddress()
        {
            try
            {
                var result = _shippingAddressRepo.FindAll().ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var message = "An error occurred while saving the entity changes.";
                if (ex.InnerException != null)
                {
                    message += " Inner Exception: " + ex.InnerException.Message;
                }
                return StatusCode(500, message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetShippingAddressByID(int id)
        {
            try
            {
                var result = _shippingAddressRepo.FindByCondition(s => s.ID == id).FirstOrDefault();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var message = "An error occurred while saving the entity changes.";
                if (ex.InnerException != null)
                {
                    message += " Inner Exception: " + ex.InnerException.Message;
                }
                return StatusCode(500, message);
            }
        }

        [HttpPost]
        public IActionResult CreateShippingAddress(ShippingAddressDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }
                List<Order> orders = new List<Order>();

                var newItem = new ShippingAddress()
                {
                    ID = item.ID,
                    Address = item.Address,
                    City = item.City,
                    Region = item.Region,
                    PostalCode = item.PostalCode,
                    Country = item.Country,
                    Order = orders
                };

                var result = _shippingAddressRepo.Create(newItem);
                return Created("customer", result);
            }
            catch (Exception ex)
            {
                var message = "An error occurred while saving the entity changes.";
                if (ex.InnerException != null)
                {
                    message += " Inner Exception: " + ex.InnerException.Message;
                }
                return StatusCode(500, message);
            }
        }

        [HttpPut]
        public IActionResult UpdateShippingAddress(MyProject.API.Models.DTO.ShippingAddressDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }

                var current = _shippingAddressRepo.FindByCondition(u => u.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }

                current.ID = item.ID;
                current.Address = item.Address;
                current.City = item.City;
                current.Region = item.Region;
                current.PostalCode = item.PostalCode;
                current.Country = item.Country;
                current.Order = new List<Order>();

                foreach (int orderID in item.Order)
                {
                    if (current.Order.Any(s => s.ID == orderID))
                    {
                        continue;
                    }
                    var newSkill = _orderRepo.FindByCondition(s => s.ID == orderID).FirstOrDefault();
                    if (newSkill == null)
                    {
                        continue;
                    }
                    current.Order.Add(newSkill);
                }

                List<Order> orderToRemove = new List<Order>();
                foreach (var order in current.Order)
                {
                    if (item.Order.Contains(order.ID))
                    {
                        continue;
                    }
                    orderToRemove.Add(order);
                }
                foreach (var order in orderToRemove)
                {
                    current.Order.Remove(order);
                }

                _shippingAddressRepo.Update(current);

                return NoContent();
            }
            catch (Exception ex)
            {
                var message = "An error occurred while saving the entity changes.";
                if (ex.InnerException != null)
                {
                    message += " Inner Exception: " + ex.InnerException.Message;
                }
                return StatusCode(500, message);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteShippingAddress(int id)
        {
            try
            {
                var result = _shippingAddressRepo.FindByCondition(s => s.ID == id).FirstOrDefault();
                if (result == null)
                {
                    return NotFound();
                }
                _shippingAddressRepo.Delete(result);
                return NoContent();
            }
            catch (Exception ex)
            {
                var message = "An error occurred while saving the entity changes.";
                if (ex.InnerException != null)
                {
                    message += " Inner Exception: " + ex.InnerException.Message;
                }
                return StatusCode(500, message);
            }
        }

    }
}
