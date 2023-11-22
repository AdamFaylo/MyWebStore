using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaid { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public int ShippingAddressID { get; set; }
        public Payment Payment { get; set; }
    }
}
