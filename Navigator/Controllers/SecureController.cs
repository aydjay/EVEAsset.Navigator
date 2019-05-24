using System.Threading.Tasks;
using EVEStandard;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Navigator.Models;

namespace Navigator.Controllers
{
    [Authorize]
    public class SecureController : Controller
    {
        private readonly EVEStandardAPI esiClient;

        public SecureController(EVEStandardAPI esiClient)
        {
            this.esiClient = esiClient;
        }


        public async Task<IActionResult> Index()
        {
            var auth = User.EsiAuth();

            var characterInfo = await esiClient.Character.GetCharacterPublicInfoV4Async(auth.CharacterId);
            var corporationInfo = await esiClient.Corporation.GetCorporationInfoV4Async(characterInfo.Model.CorporationId);

            var locationInfo = await esiClient.Location.GetCharacterLocationV1Async(auth);
            var location = await esiClient.Universe.GetSolarSystemInfoV4Async(locationInfo.Model.SolarSystemId);

            var model = new SecureViewModel
            {
                CharacterName = characterInfo.Model.Name,
                CorporationName = corporationInfo.Model.Name,
                CharacterLocation = location.Model.Name
            };

            return View(model);
        }
    }
}