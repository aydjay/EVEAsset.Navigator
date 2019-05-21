using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVEStandard;
using EVEStandard.Enumerations;
using EVEStandard.Models;
using Microsoft.Extensions.Caching.Memory;
using Navigator.Consts;
using Navigator.Interfaces;

namespace Navigator.Cache
{
    public class UniverseCache : IUniverseCache
    {
        private const string UnknownId = "Unknown";
        private readonly EVEStandardAPI _api;
        private readonly IMemoryCache _cache;
        
        public UniverseCache(IMemoryCache cache, EVEStandardAPI api)
        {
            _cache = cache;
            _api = api;

            if (!_cache.TryGetValue(MemoryCacheKeys.UniverseMapping, out List<UniverseIdsToNames> _universeMapping))
            {
                _universeMapping = new List<UniverseIdsToNames>();
                _cache.Set(MemoryCacheKeys.UniverseMapping, _universeMapping, new MemoryCacheEntryOptions
                {
                    Priority = CacheItemPriority.NeverRemove
                });
            }
        }

        public async Task<int> PopulateIdCache(IEnumerable<int> universeIds)
        {
            var _universeMapping = _cache.Get<List<UniverseIdsToNames>>(MemoryCacheKeys.UniverseMapping);
            var idsToQuery = new List<int>();

            foreach (var id in universeIds)
            {
                if (await GetNameForId(id) == UnknownId)
                {
                    idsToQuery.Add(id);
                }
            }
            
            if (idsToQuery.Count > 0)
            {
                var affiliation = await _api.Universe.GetNamesAndCategoriesFromIdsV3Async(idsToQuery);

                foreach (var mapping in affiliation.Model)
                {
                    _universeMapping.Add(mapping);
                }
            }

            return await Task.FromResult(idsToQuery.Count);
        }

        public Task<string> GetNameForId(int id)
        {
            var _universeMapping = _cache.Get<List<UniverseIdsToNames>>(MemoryCacheKeys.UniverseMapping);

            if (_universeMapping.Any(x => x.Id == id) == false)
            {
                return Task.FromResult(UnknownId);
            }

            return Task.FromResult(_universeMapping.First(x => x.Id == id).Name);
        }        
        
        public Task<int> GetIdFromName(string name)
        {
            var _universeMapping = _cache.Get<List<UniverseIdsToNames>>(MemoryCacheKeys.UniverseMapping);

            if (_universeMapping.Any(x => x.Name == name) == false)
            {
                return Task.FromResult(0);
            }

            return Task.FromResult(_universeMapping.First(x => x.Name == name).Id);
        }

        public void PrepopulateData(IEnumerable<UniverseIdsToNames> solarSystems)
        {
            var _universeMapping = _cache.Get<List<UniverseIdsToNames>>(MemoryCacheKeys.UniverseMapping);

            _universeMapping.AddRange(solarSystems);
        }
            
        public IEnumerable<UniverseIdsToNames> GetAllByCategory(CategoryEnum category)
        {
            var _universeMapping = _cache.Get<List<UniverseIdsToNames>>(MemoryCacheKeys.UniverseMapping);

            return _universeMapping.Where(x => x.Category == CategoryEnum.solar_system);
        }
    }
}