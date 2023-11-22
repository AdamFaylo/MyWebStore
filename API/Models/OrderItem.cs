using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models
{
    public class OrderItem
    {
        [Key]
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
        public int OrderID { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}
