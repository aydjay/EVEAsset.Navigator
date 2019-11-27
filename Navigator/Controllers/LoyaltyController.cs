using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVEStandard;
using EVEStandard.Models.API;
using Microsoft.AspNetCore.Mvc;
using Navigator.DAL;
using Navigator.Interfaces;
using Navigator.Models;

namespace Navigator.Controllers
{
    public class LoyaltyController : Controller
    {
        private readonly EVEStandardAPI _api;
        private readonly IServiceProvider _provider;
        private readonly IUniverseCache _universeCache;
        private TranquilityContext _tranquilityDbContext;

        public LoyaltyController(IServiceProvider provider)
        {
            _provider = provider;
            _api = (EVEStandardAPI) provider.GetService(typeof(EVEStandardAPI));
            _tranquilityDbContext = (TranquilityContext) provider.GetService(typeof(TranquilityContext));
        }

        public async Task<IActionResult> Index()
        {
            AuthDTO auth;
            try
            {
                auth = User.GetAuth();
            }
            catch (UnauthorizedAccessException)
            {
                return Content("You must auth with eve online.");
            }

            //Grab LP Details
            var loyaltyPoints = await _api.Loyalty.GetLoyaltyPointsV1Async(auth);
            var loyaltyPointsWrapped = new List<LoyaltyPointDisplayWrapper>();

            foreach (var loyaltyPoint in loyaltyPoints.Model)
            {
                var npcCorpData = _tranquilityDbContext.InvUniqueNames.SingleOrDefault(x =>
                    x.ItemId == loyaltyPoint.CorporationId);

                loyaltyPointsWrapped.Add(new LoyaltyPointDisplayWrapper(npcCorpData, loyaltyPoint));


            }
            var viewModel = new LoyaltyViewModel(loyaltyPointsWrapped.OrderByDescending(x => x.LoyaltyPointQuantity).ToList());

            return View(viewModel);
        }
    }
}