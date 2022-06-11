using Microsoft.AspNetCore.Mvc;

namespace Rudniev.TaskScheduler.WebClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
