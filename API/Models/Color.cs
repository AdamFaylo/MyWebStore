using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models
{
    public class Color
    {
        [Key]
        public int ID { get; set; }
        
        public string Name { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}
