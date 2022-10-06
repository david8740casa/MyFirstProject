using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    public class OwenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
