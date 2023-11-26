using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.API.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaid { get; set; }

        // Define foreign keys
        public int CustomerID { get; set; }
 
        public int CartId{ get; set; }
        public int ShippingAddressID { get; set; }

        // Define navigation properties for relationships
        public Cart Cart { get; set; }
        public virtual Customer Customer { get; set; }
        //public virtual Cart Cart { get; set; }
        public virtual ShippingAddress ShippingAddress { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
