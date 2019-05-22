using System;
using System.Collections.Generic;
using EVEStandard.Models;
using Microsoft.Extensions.DependencyInjection;
using Navigator.Interfaces;

namespace Navigator.Models
{
    public class BookmarkSection
    {
        public BookmarkSection(IServiceProvider provider, List<BookmarkFolder> folders, List<Bookmark> bookmarks, int system)
        {
            BookmarkFolders = folders;
            Bookmarks = bookmarks;
            System = system;

            UniverseCache = provider.GetService<IUniverseCache>();
            JumpCache = provider.GetService<IJumpCache>();
        }

        public List<BookmarkFolder> BookmarkFolders { get; set; }

        public List<Bookmark> Bookmarks { get; set; }

        public IUniverseCache UniverseCache { get; set; }

        public IJumpCache JumpCache { get; set; }

        public int System { get; set; }
    }
}