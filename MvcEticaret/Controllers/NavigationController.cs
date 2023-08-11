using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.Controllers
{
    public class NavigationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
