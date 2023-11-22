using MyProject.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyProject.API.Models.Collections
{
    public class LoginInfo
    {

        [Required]
        [MinLength(3, ErrorMessage = "First name must be at least 3 chars")]
        [MaxLength(50, ErrorMessage = "First name must be less then 50 chars")]
        public string? FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Last name must be at least 3 chars")]
        [MaxLength(50, ErrorMessage = "Last name must be less then 50 chars")]
        public string? LastName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "User Name must be at least 3 chars")]
        [MaxLength(50, ErrorMessage = "User Name must be less then 50 chars")]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "The Password must be at least 8 chars")]
        [MaxLength(50, ErrorMessage = "The Password must be less then 50 chars")]
        public string? Password { get; set; }
  
    }
}
