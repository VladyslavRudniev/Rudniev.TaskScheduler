using Microsoft.AspNetCore.Mvc;

namespace Rudniev.TaskScheduler.WebClient.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
