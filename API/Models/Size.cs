using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models
{
    public class Size
    {
        [Key]
        public int ID { get; set; }
        public string SizeName { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}
