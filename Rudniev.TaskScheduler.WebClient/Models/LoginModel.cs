using System.ComponentModel.DataAnnotations;

namespace Rudniev.TaskScheduler.WebClient.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter your Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Enter your Password")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Minimal symbol must be 8")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
