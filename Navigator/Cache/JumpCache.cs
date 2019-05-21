using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVEStandard;
using Microsoft.Extensions.Caching.Memory;
using Navigator.Consts;
using Navigator.Interfaces;
using Navigator.Models;

namespace Navigator.Cache
{
    public class JumpCache : IJumpCache
    {
        private readonly EVEStandardAPI _api;
        private readonly IMemoryCache _cache;

        public JumpCache(IMemoryCache cache, EVEStandardAPI api)
        {
            _cache = cache;
            _api = api;

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
                    var result = await _api.Routes.GetRouteV1Async(route.From, route.To);
                    route.NavigatedSystems.AddRange(result.Model);
                }
                catch
                {
                }


                _routeMapping.Add(route);
            }

            return await Task.FromResult(_routeMapping.First(x => x.From == fromId && x.To == toId).NavigatedSystems.Count);
        }

        public Task<int> GetJumpsDistance(int fromId, int toId)
        {
            var _routeMapping = _cache.Get<List<Route>>(MemoryCacheKeys.JumpMapping);
            var jumps = _routeMapping.FirstOrDefault(x => x.From == fromId && x.To == toId);
            if (jumps == null)
            {
                return Task.FromResult(0);
            }

            return Task.FromResult(jumps.NavigatedSystems.Count);
        }
    }
}