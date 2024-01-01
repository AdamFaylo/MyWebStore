﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.API.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime AddedOn { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        public int DepartmentID { get; set; }
        public SubCategory SubCategory { get; set; }
        public int SubCategoryID { get; set; }
        public ICollection<Color> Colors { get; set; }
        public ICollection<GalleryImage> GalleryImage { get; set; }
        public ICollection<Size> Size { get; set; }
    }
}
