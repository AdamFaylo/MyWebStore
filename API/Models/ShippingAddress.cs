using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models
{
    public class ShippingAddress
    {
        [Key]
   
        public int ID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public List<Order> Order { get; set; }
    }
}
