﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Models.DTO;
using MyProject.API.Repositories.Abstract;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ILogger _logger;
        private readonly IOrderItemRepository _orderItemRepo;

        public OrderController(
            IOrderRepository _orderRepository,
            IOrderItemRepository _orderItemRepo,
            ILogger<OrderController> _logger
            )
        {
            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));
            this._orderItemRepo = _orderItemRepo ?? throw new ArgumentNullException(nameof(_orderItemRepo));
            this._orderRepository = _orderRepository ?? throw new ArgumentNullException(nameof(_orderRepository));
        }

        [HttpGet]
        public IActionResult GetAllOrder()
        {
            try
            {
                var result = _orderRepository.FindAll().ToList();
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
        public IActionResult GetByOrderId(int id)
        {
            try
            {
                var result = _orderRepository.FindByCondition(o => o.ID == id).FirstOrDefault();
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
        public IActionResult CreateOrder(OrderDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }
                List<OrderItem> orderItems = new List<OrderItem>();

                var newOrderItem = new Order()
                {
                    ID = item.ID,
                    IsPaid = item.IsPaid,
                    CustomerID = item.CustomerID,
                    OrderDate = item.OrderDate,
                    OrderItems = orderItems,
                    ShippingAddressID = item.ShippingAddressID,
                    
                };

                var result = _orderRepository.Create(newOrderItem);
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
        public IActionResult UpdateOrder(OrderDTO item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest();
                }
                var current = _orderRepository.FindByCondition(o=> o.ID == item.ID).FirstOrDefault();
                if (current == null)
                {
                    return NoContent();
                }

                current.ID = item.ID;
                current.IsPaid = item.IsPaid;
                current.CustomerID = item.CustomerID;
                current.OrderDate = item.OrderDate;
                current.OrderItems = new List<OrderItem>();
                current.ShippingAddressID = item.ShippingAddressID;
                current.CustomerID = item.CustomerID;

                foreach (var orderItemID in item.OrderItems)
                {
                    if (current.OrderItems.Any(o => o.ID == orderItemID))
                    {
                        continue;
                    }
                    var newOrderItem = _orderItemRepo.FindByCondition(O=>O.ID == orderItemID).FirstOrDefault();
                    if (newOrderItem == null)
                    {
                        continue;
                    }
                    current.OrderItems.Add(newOrderItem);
                }

                List<OrderItem> orderItemToRemove = new List<OrderItem>();
                foreach (var orderItemID in current.OrderItems)
                {
                    if (item.OrderItems.Contains(orderItemID.ID))
                    {
                        continue;
                    }
                    orderItemToRemove.Add(orderItemID);
                }
                foreach (var orderItem in orderItemToRemove)
                {
                    current.OrderItems.Remove(orderItem);
                }
                _orderRepository.Update(current);
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
        public IActionResult Delete(int id)
        {
            try
            {
                var order = _orderRepository.FindByCondition(o => o.ID == id).FirstOrDefault();
                if (order == null)
                {
                    return NoContent();
                }
                _orderRepository.Delete(order);
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
