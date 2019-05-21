using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using EVEStandard.Enumerations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Navigator.Interfaces;

namespace Navigator.Repositories
{
    public class StaticDataRepository : IStaticDataRepository
    {
        private readonly IUniverseCache _universeCache;
        private Regex _regex;
        public StaticDataRepository(IUniverseCache universeCache)
        {
            
            _regex = new Regex(@"J\d{6}|Thera");
            _universeCache = universeCache;
        }

        public IEnumerable<SelectListItem> GetAllSystems()
        {
            foreach (var system in _universeCache.GetAllByCategory(CategoryEnum.solar_system).Where( x => !IsWormhole(x.Name)))
            {
                yield return new SelectListItem(system.Name, system.Id.ToString());
            }
        }

        private bool IsWormhole(string systemName)
        {
            //There must be a property in the SDE to denote if a system is a wormhole, but for now, just going to regex
            //to get appropriate systems.
            Match match = _regex.Match(systemName);
            return match.Success;
        }
    }
}