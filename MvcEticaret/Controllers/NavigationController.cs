using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.Controllers
{
    public class NavigationController : Controller
    {
        public IActionResult Navigation()
        {
            return View();
        }
    }
}
