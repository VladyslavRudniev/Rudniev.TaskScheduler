using System.ComponentModel.DataAnnotations;

namespace Rudniev.TaskScheduler.WebClient.Models
{
    public class RegistrationViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public string ReturnUrl { get; set; }
    }
}
