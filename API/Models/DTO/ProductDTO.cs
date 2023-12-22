using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.API.Models.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.DTO
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public int SubCategoryID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string>? Colors { get; set; }
        public List<GalleryImageDTO> GalleryImage { get; set; }
        public List<string>? Size { get; set; }

    }
}
