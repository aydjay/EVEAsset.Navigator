using System.Collections.Generic;
using System.Linq;
using EVEStandard.Enumerations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Navigator.Interfaces;

namespace Navigator.Repositories
{
    public class StaticDataRepository : IStaticDataRepository
    {
        private readonly SolarSystemRepository _solarSystemRepository;
        private readonly IUniverseCache _universeCache;

        public StaticDataRepository(IUniverseCache universeCache)
        {
            _universeCache = universeCache;
            _solarSystemRepository = new SolarSystemRepository();
        }

        public IEnumerable<SelectListItem> GetAllSystems()
        {
            var systems = new List<SelectListItem>();

            foreach (var system in _universeCache.GetAllByCategory(CategoryEnum.solar_system).Where(x => !_solarSystemRepository.IsWormhole(x.Name)))
            {
                systems.Add(new SelectListItem(system.Name, system.Id.ToString()));
            }

            systems = systems.OrderBy(x => x.Text).ToList();

            return systems;
        }
    }
}