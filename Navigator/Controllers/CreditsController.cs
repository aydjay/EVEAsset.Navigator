using Microsoft.AspNetCore.Mvc;

namespace Navigator.Controllers
{
    public class CreditsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}