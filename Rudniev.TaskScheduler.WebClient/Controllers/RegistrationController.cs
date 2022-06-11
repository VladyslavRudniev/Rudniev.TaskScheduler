using Microsoft.AspNetCore.Mvc;

namespace Rudniev.TaskScheduler.WebClient.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
