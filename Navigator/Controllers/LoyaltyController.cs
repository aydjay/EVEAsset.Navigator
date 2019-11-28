using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVEStandard;
using EVEStandard.Models.API;
using Microsoft.AspNetCore.Mvc;
using Navigator.DAL;
using Navigator.DAL.SDE;
using Navigator.Models;

namespace Navigator.Controllers
{
    public class LoyaltyController : Controller
    {
        private readonly EVEStandardAPI _api;
        private readonly TranquilityContext _tranquilityDbContext;

        public LoyaltyController(IServiceProvider provider)
        {
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
                var npcCorpName = _tranquilityDbContext.InvUniqueNames.SingleOrDefault(x =>
                    x.ItemId == loyaltyPoint.CorporationId);

                loyaltyPointsWrapped.Add(new LoyaltyPointDisplayWrapper(npcCorpName, loyaltyPoint));
            }

            var viewModel = new LoyaltyViewModel(loyaltyPointsWrapped.OrderByDescending(x => x.LoyaltyPointQuantity).ToList());

            return View(viewModel);
        }

        public async Task<IActionResult> LoyaltyStoreRewards(int corporationId)
        {
            var loyaltyRewards = await _api.Loyalty.ListLoyaltyStoreOffersV1Async(corporationId);
            var loyaltyPointsWrapped = new List<LoyaltyStoreOfferDisplayWrapper>();

            foreach (var loyaltyPoint in loyaltyRewards.Model)
            {
                var itemName = _tranquilityDbContext.InvTypes.SingleOrDefault(x =>
                                   x.TypeId == loyaltyPoint.TypeId) ?? new InvTypes {TypeName = "N/a", TypeId = loyaltyPoint.TypeId};

                loyaltyPointsWrapped.Add(new LoyaltyStoreOfferDisplayWrapper(itemName, loyaltyPoint));
            }

            var viewModel = new LoyaltyRewardsViewModel(loyaltyPointsWrapped);

            return View(viewModel);
        }
    }
}