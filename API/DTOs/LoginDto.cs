using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required(ErrorMessage=("Password Required"))]
        public string Password { get; set; }
    }
}