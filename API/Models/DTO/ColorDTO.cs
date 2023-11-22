using MyProject.API.Models;
using System.ComponentModel.DataAnnotations;

namespace API.Models.DTO
{
    public class ColorDTO 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProductID { get; set; }
    }
}
