using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EVEStandard;
using Microsoft.AspNetCore.Mvc;
using Navigator.Models;

namespace Navigator.Controllers
{
    public class HomeController : Controller
    {
        private readonly EVEStandardAPI _api;

        public HomeController(EVEStandardAPI api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }

            var characterId = User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier);

            var portraits = await _api.Character.GetCharacterPortraitsV2Async(int.Parse(characterId.Value));
            var info = await _api.Character.GetCharacterPublicInfoV4Async(int.Parse(characterId.Value));

            return View(new IndexViewModel(portraits.Model, info.Model));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
    