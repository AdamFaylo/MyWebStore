using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ICustomerRepository _customerRepo;
        private readonly IOrderRepository _orderRepo;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(
            IConfiguration config,
            ICustomerRepository customerRepo,
            IOrderRepository orderRepo,
            ILogger<CustomerController> logger
            )
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _customerRepo = customerRepo ?? throw new ArgumentNullException(nameof(customerRepo));
            _orderRepo = orderRepo ?? throw new ArgumentNullException(nameof(orderRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult GetAllCustomer()
        {
            try
            {
                var result = _customerRepo.FindAll().ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleException(ex, "getting all customers");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetByIdCustomer(int id)
        {
            try
            {
                var result = _customerRepo.FindByCondition(c => c.ID == id).ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleException(ex, "getting customer by ID");
            }
        }

        [HttpPost]
        public IActionResult CreateCustomer(Models.DTO.CustomerDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest("Customer data is null");
                }

                var newItem = new Customer()
                {
                    ID = item.ID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Mail = item.Mail,
                    Order = new List<Order>()
                };

                _customerRepo.Create(newItem);
                return Created("customer", newItem);
            }
            catch (Exception ex)
            {
                return HandleException(ex, "creating the customer");
            }
        }

        [HttpPut]
        public IActionResult UpdateCustomer(Models.DTO.CustomerDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest("Customer data is null");
                }

                var current = _customerRepo.FindByCondition(u => u.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NotFound();
                }

                UpdateCustomerOrders(current, item);
                _customerRepo.Update(current);

                return NoContent();
            }
            catch (Exception ex)
            {
                return HandleException(ex, "updating the customer");
            }
        }

        private void UpdateCustomerOrders(Customer customer, Models.DTO.CustomerDTO item)
        {
            // Your logic to update orders
            // ...
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _customerRepo.FindByCondition(c => c.ID == id).FirstOrDefault();
                if (result == null)
                {
                    return NotFound();
                }

                _customerRepo.Delete(result);
                return NoContent();
            }
            catch (Exception ex)
            {
                return HandleException(ex, "deleting the customer");
            }
        }

        private IActionResult HandleException(Exception ex, string actionName)
        {
            _logger.LogCritical(ex, $"An error occurred while {actionName}.");
            return StatusCode(500, new
            {
                Message = $"An error occurred while {actionName}.",
                ExceptionMessage = ex.Message,
                InnerExceptionMessage = ex.InnerException?.Message,
                StackTrace = ex.StackTrace
            });
        }
    }
}
