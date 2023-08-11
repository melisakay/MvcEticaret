using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.Controllers
{
    public class FooterController : Controller
    {
        public IActionResult Footer()
        {
            return View();
        }
    }
}
