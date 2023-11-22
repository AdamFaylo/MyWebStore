using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public Order Order { get; set; }
        public int OrderID { get; set; }
    }
}
