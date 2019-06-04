using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVEStandard;
using Microsoft.Extensions.Caching.Memory;
using Navigator.Consts;
using Navigator.DAL;
using Navigator.DAL.Navigator;
using Navigator.Interfaces;
using Navigator.Repositories;

namespace Navigator.Cache
{
    public class JumpCache : IJumpCache
    {
        private readonly EVEStandardAPI _api;
        private readonly IMemoryCache _cache;
        private readonly SolarSystemRepository _solarSystemRepository;
        private readonly TranquilityContext _universeCache;

        public JumpCache(IMemoryCache cache, EVEStandardAPI api, TranquilityContext universeCache)
        {
            _cache = cache;
            _api = api;
            _universeCache = universeCache;
            _solarSystemRepository = new SolarSystemRepository();

            if (!_cache.TryGetValue(MemoryCacheKeys.UniverseMapping, out List<Route> _routeMapping))
            {
                _routeMapping = new List<Route>();
                _cache.Set(MemoryCacheKeys.JumpMapping, _routeMapping, new MemoryCacheEntryOptions
                {
                    Priority = CacheItemPriority.NeverRemove
                });
            }
        }

        public async Task<int> PopulateJumpCache(int fromId, int toId)
        {
            var _routeMapping = _cache.Get<List<Route>>(MemoryCacheKeys.JumpMapping);

            if (_routeMapping.Any(x => x.From == fromId && x.To == toId) == false)
            {
                var route = new Route(fromId, toId);

                try
                {
                    if (fromId != toId)
                    {
                        var isAnySystemAWormhole = IsAnySystemAWormhole(new List<int> {fromId, toId});

                        if (isAnySystemAWormhole == false)
                        {
                            var result = await _api.Routes.GetRouteV1Async(route.From, route.To);
                            route.NavigatedSystems.AddRange(result.Model);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }


                _routeMapping.Add(route);
            }

            return await Task.FromResult(_routeMapping.First(x => x.From == fromId && x.To == toId).NavigatedSystems.Count);
        }

        public Task<int> GetJumpsDistance(int fromId, int toId)
        {
            if (fromId == toId)
            {
                return Task.FromResult(0);
            }

            var _routeMapping = _cache.Get<List<Route>>(MemoryCacheKeys.JumpMapping);
            var jumps = _routeMapping.FirstOrDefault(x => x.From == fromId && x.To == toId);
            if (jumps == null)
            {
                return Task.FromResult(0);
            }

            return Task.FromResult(jumps.NavigatedSystems.Count);
        }

        private bool IsAnySystemAWormhole(List<int> ids)
        {
            //Todo: Rework to get it back with one query rather than check each id individually.
            foreach (var id in ids)
            {
                var system = _universeCache.MapSolarSystems.First(x => x.SolarSystemId == id);
                //Todo: Cross reference the region id the system is in as there is a set of regions which are just for WH's
                var result = _solarSystemRepository.IsWormhole(system.SolarSystemName);
                if (result)
                {
                    return result;
                }
            }

            return false;
        }
    }
}