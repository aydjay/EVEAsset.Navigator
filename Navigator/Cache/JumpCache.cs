using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVEStandard;
using Navigator.DAL;
using Navigator.DAL.Navigator;
using Navigator.Interfaces;
using Navigator.Repositories;

namespace Navigator.Cache
{
    public class JumpCache : IJumpCache
    {
        private readonly EVEStandardAPI _api;
        private readonly SolarSystemRepository _solarSystemRepository;
        private readonly TranquilityContext _tranquilityDbContext;
        private readonly NavigatorContext _navigatorDbContext;

        public JumpCache(IServiceProvider services)
        {
            _api = (EVEStandardAPI) services.GetService(typeof(EVEStandardAPI));
            _tranquilityDbContext =   (TranquilityContext) services.GetService(typeof(TranquilityContext));
            _navigatorDbContext =   (NavigatorContext) services.GetService(typeof(NavigatorContext));

            _solarSystemRepository = new SolarSystemRepository();
        }

        public async Task<int> PopulateJumpCache(int fromId, int toId)
        {
            var route = _navigatorDbContext.Routes.FirstOrDefault(x => x.From == fromId && x.To == toId);

            if (route == null)
            {
                route = new Route(fromId, toId);

                try
                {
                    if (fromId != toId)
                    {
                        var isAnySystemAWormhole = IsAnySystemAWormhole(new List<int> {fromId, toId});

                        if (isAnySystemAWormhole == false)
                        {
                            var result = await _api.Routes.GetRouteV1Async(route.From, route.To);
                            route.NavigatedSystems.AddRange(result.Model);

                            List<Route> discoveredRoutes = ComputeRoutes(route);
                            
                            _navigatorDbContext.Routes.AddRange(discoveredRoutes);

                            await _navigatorDbContext.SaveChangesAsync();

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
            }

            return await Task.FromResult(route.NavigatedSystems.Count);
        }

        private List<Route> ComputeRoutes(Route route)
        {
            List<Route> rtnList = new List<Route> {route};

            //First item in the route is the starting system
            for (int i = 1; i < route.NavigatedSystems.Count; i++)
            {
                var discoveredRoute = new Route(route.NavigatedSystems[i], route.To);
                
                discoveredRoute.NavigatedSystems.AddRange(route.NavigatedSystems.GetRange(i, route.NavigatedSystems.Count- i));
             
                rtnList.Add(discoveredRoute);
            }

            return rtnList;
        }

        public Task<int> GetJumpsDistance(int fromId, int toId)
        {
            if (fromId == toId)
            {
                return Task.FromResult(0);
            }

            var jumps = _navigatorDbContext.Routes.FirstOrDefault(x => x.From == fromId && x.To == toId);
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
                var system = _tranquilityDbContext.MapSolarSystems.First(x => x.SolarSystemId == id);
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