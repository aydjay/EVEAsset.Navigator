using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Navigator.Interfaces;
using Navigator.Repositories;

namespace Navigator.Models
{
    public class BookmarkViewModel
    {
        private readonly IStaticDataRepository _repository;

        public BookmarkViewModel(BookmarkSection personalBookmarks, BookmarkSection corpBookmarks, string system)
        {
            PersonalBookmarks = personalBookmarks;
            CorpBookmarks = corpBookmarks;

            _repository = new StaticDataRepository(PersonalBookmarks.UniverseCache);

            System = system;
            //Systems.First(x =>x.Value == system).Selected = true;


        }

        public BookmarkSection PersonalBookmarks { get; set; }
        public BookmarkSection CorpBookmarks { get; set; }

        [Display(Name = "Solar System")]
        public IEnumerable<SelectListItem> Systems => _repository.GetAllSystems();

        public string System { get; set; }
    }
}