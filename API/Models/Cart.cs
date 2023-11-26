using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.API.Models
{
    public class Cart
    {

        public int CartId { get; set; }

        public int CartType { get; set; }

        public User? User { get; set; }
        public int UserID { get; set; }

        public virtual ICollection<OrderItem>? OrderItems { get; set; }
    }
}