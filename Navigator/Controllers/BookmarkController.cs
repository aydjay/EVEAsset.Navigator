using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVEStandard;
using EVEStandard.Models.API;
using Microsoft.AspNetCore.Mvc;
using Navigator.Cache;
using Navigator.Models;

namespace Navigator.Controllers
{
    public class BookmarkController : Controller
    {
        private readonly EVEStandardAPI _api;
        private readonly UniverseCache _universeCache;
        private readonly JumpCache _jumpCache;

        public BookmarkController(EVEStandardAPI api, UniverseCache universeCache, JumpCache jumpCache)
        {
            _api = api;
            _universeCache = universeCache;
            _jumpCache = jumpCache;
        }

        public async Task<IActionResult> Index(string system = "Jita")
        {
            AuthDTO auth;
            try
            {
                auth = User.EsiAuth();
            }
            catch (UnauthorizedAccessException)
            {
                return Content("You must auth with eve online.");
            }

            //Grab bookmarks
            var personalBookmarkSection = await GetPersonalBookmarkSection();
            var universeIds = GetIdsForCaching(personalBookmarkSection);

            var corporationBookmarkSection = await GetCorporationBookmarkSection();
            universeIds.AddRange(GetIdsForCaching(corporationBookmarkSection));

            //Query ESI for real name
            await _universeCache.PopulateIdCache(universeIds.Distinct());

            var viewModel = new BookmarkViewModel(personalBookmarkSection, corporationBookmarkSection, system);

            return View(viewModel);
        }

        private static List<int> GetIdsForCaching(BookmarkSection section)
        {
            //Grab the id's we want to find out the real name for
            return section.Bookmarks.DistinctBy(x => x.CreatorId).Select(x => x.CreatorId).ToList();
        }

        private async Task<BookmarkSection> GetPersonalBookmarkSection()
        {
            var bookmarks = await _api.Bookmarks.ListBookmarksV2Async(User.EsiAuth());
            var folders = await _api.Bookmarks.ListBookmarkFoldersV2Async(User.EsiAuth());

            var section = new BookmarkSection(folders.Model, bookmarks.Model, _universeCache, _jumpCache);

            return section;
        }

        private async Task<BookmarkSection> GetCorporationBookmarkSection()
        {
            var auth = User.EsiAuth();
            var charInfo = await _api.Character.GetCharacterPublicInfoV4Async(auth.CharacterId);

            var bookmarks = await _api.Bookmarks.ListCorporationBookmarksV1Async(auth, charInfo.Model.CorporationId);
            var folders = await _api.Bookmarks.ListCorporationBookmarkFoldersV1Async(auth, charInfo.Model.CorporationId);
            var section = new BookmarkSection(folders.Model, bookmarks.Model, _universeCache, _jumpCache);
            return section;
        }
    }
}