using System.Collections.Generic;
using System.IO;
using EVEStandard;
using EVEStandard.Enumerations;
using EVEStandard.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Navigator.Cache;
using Newtonsoft.Json;

namespace Navigator.Factory
{
    public static class UniverseCacheFactory
    {
        public static UniverseCache Build(IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();

            var cache = provider.GetService<IMemoryCache>();
            var api = provider.GetService<EVEStandardAPI>();

            var universeCache = new UniverseCache(cache, api);
            universeCache.PrepopulateData(LoadSolarSystems());
            return universeCache;
        }

        private static IEnumerable<UniverseIdsToNames> LoadSolarSystems()
        {
            var systems = JsonConvert.DeserializeObject<List<SolarSystem>>(File.ReadAllText(".\\Factory\\Data\\universe.json"));

            var rtnSystems = new List<UniverseIdsToNames>();

            foreach (var solarSystem in systems)
            {
                rtnSystems.Add(new UniverseIdsToNames {Category = CategoryEnum.solar_system, Id = solarSystem.solarSystemID, Name = solarSystem.solarSystemName});
            }

            return rtnSystems;
        }
    }

    internal class SolarSystem
    {
        public string solarSystemName { get; set; }
        public int solarSystemID { get; set; }
    }
}