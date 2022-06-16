using System.ComponentModel.DataAnnotations;

namespace Rudniev.TaskScheduler.WebClient.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Enter your Login")]
        [MinLength(4, ErrorMessage = "Minimal symbol must be 4")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Enter your Password")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Minimal symbol must be 8")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Email must be validation")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your ConfirmPassword")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Minimal symbol for password must be 4")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string ReturnUrl { get; set; }
    }
}
