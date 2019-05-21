using System.Collections.Generic;
using EVEAsset.Navigator.Cache;
using EVEStandard.Models;

namespace EVEAsset.Navigator.Models
{
    public class BookmarkSection
    {
        public BookmarkSection(List<BookmarkFolder> folders, List<Bookmark> bookmarks, UniverseCache universeCache, JumpCache jumpCache)
        {
            BookmarkFolders = folders;
            Bookmarks = bookmarks;

            UniverseCache = universeCache;
            JumpCache = jumpCache;

            //await JumpCache.PopulateJumpCache(bookmarks);

        }

        public List<BookmarkFolder> BookmarkFolders { get; set; }

        public List<Bookmark> Bookmarks { get; set; }

        public UniverseCache UniverseCache { get; set; }

        public JumpCache JumpCache { get; set; }

        public string System { get; set; }
    }
}