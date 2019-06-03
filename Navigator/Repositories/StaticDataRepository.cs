using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Navigator.DAL;
using Navigator.Interfaces;

namespace Navigator.Repositories
{
    public class StaticDataRepository : IStaticDataRepository
    {
        private readonly TranquilityContext _dbContext;
        private readonly SolarSystemRepository _solarSystemRepository;

        public StaticDataRepository(IServiceProvider provider)
        {
            _dbContext = (TranquilityContext) provider.GetService(typeof(TranquilityContext));

            _solarSystemRepository = new SolarSystemRepository();
        }

        public IEnumerable<SelectListItem> GetAllSystems()
        {
            var systems = new List<SelectListItem>();

            foreach (var system in _dbContext.MapSolarSystems.Where(x => !_solarSystemRepository.IsWormhole(x.SolarSystemName)))
            {
                systems.Add(new SelectListItem(system.SolarSystemName, system.SolarSystemId.ToString()));
            }

            systems = systems.OrderBy(x => x.Text).ToList();

            return systems;
        }
    }
}