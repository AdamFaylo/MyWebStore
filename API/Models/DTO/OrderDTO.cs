﻿using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models.DTO
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public bool IsPaid { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public List<int> OrderItems { get; set; }
        public int ShippingAddressID { get; set; }
        public int OrderItemID { get; set; }
    }
}
