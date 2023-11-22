using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
     
        public int CartType { get; set; }
        public int CardCount { get; set; }
        public int CardTypeCount { get; set;}
        public User? User { get; set; }
        public int UserID { get; set; }

    }
}