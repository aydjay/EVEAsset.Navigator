using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVEStandard;
using EVEStandard.Models.API;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Navigator.Consts;
using Navigator.Interfaces;
using Navigator.Models;

namespace Navigator.Controllers
{
    public class BookmarkController : Controller
    {
        private readonly EVEStandardAPI _api;
        private readonly IJumpCache _jumpCache;
        private readonly IServiceProvider _provider;
        private readonly IUniverseCache _universeCache;

        public BookmarkController(IServiceProvider provider)
        {
            _provider = provider;
            _api = (EVEStandardAPI) provider.GetService(typeof(EVEStandardAPI));
            _universeCache = provider.GetService<IUniverseCache>();
            _jumpCache = provider.GetService<IJumpCache>();
        }

        public async Task<IActionResult> Index(string system = SolarSystemId.Jita)
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

            //Grab bookmarks
            var personalBookmarkSection = await GetPersonalBookmarkSection(int.Parse(system));
            var universeIds = GetIdsForCaching(personalBookmarkSection);

            var corporationBookmarkSection = await GetCorporationBookmarkSection(int.Parse(system));
            universeIds.AddRange(GetIdsForCaching(corporationBookmarkSection));

            //Query ESI for real name
            await _universeCache.PopulateIdCache(universeIds.Distinct());

            await SubmitSystemsToRouteCache(personalBookmarkSection, int.Parse(system));
            await SubmitSystemsToRouteCache(corporationBookmarkSection, int.Parse(system));

            var viewModel = new BookmarkViewModel(personalBookmarkSection, corporationBookmarkSection, system);

            return View(viewModel);
        }

        private static List<int> GetIdsForCaching(BookmarkSection section)
        {
            //Grab the id's we want to find out the real name for
            return section.Bookmarks.DistinctBy(x => x.CreatorId).Select(x => x.CreatorId).ToList();
        }

        private async Task<BookmarkSection> GetPersonalBookmarkSection(int system)
        {
            var bookmarks = await _api.Bookmarks.ListBookmarksV2Async(User.GetAuth());
            var folders = await _api.Bookmarks.ListBookmarkFoldersV2Async(User.GetAuth());

            var section = new BookmarkSection(_provider, folders.Model, bookmarks.Model, system);

            return section;
        }

        private async Task<BookmarkSection> GetCorporationBookmarkSection(int system)
        {
            var auth = User.GetAuth();
            var charInfo = await _api.Character.GetCharacterPublicInfoV4Async(auth.CharacterId);

            var bookmarks = await _api.Bookmarks.ListCorporationBookmarksV1Async(auth, charInfo.Model.CorporationId);
            var folders = await _api.Bookmarks.ListCorporationBookmarkFoldersV1Async(auth, charInfo.Model.CorporationId);
            var section = new BookmarkSection(_provider, folders.Model, bookmarks.Model, system);
            return section;
        }

        private async Task<int> SubmitSystemsToRouteCache(BookmarkSection section, int toSystemId)
        {
            foreach (var bookmark in section.Bookmarks)
            {
                await _jumpCache.PopulateJumpCache(bookmark.LocationId, toSystemId);
            }

            return 0;
        }
    }
}