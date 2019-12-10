using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Navigator.DAL;
using Navigator.DAL.Navigator;
using Navigator.Models;
using Newtonsoft.Json;

namespace Navigator.Services
{
    public class EveScoutService
    {
        private readonly NavigatorContext _navigatorContext;
        public HttpClient Client { get; }

        public EveScoutService(HttpClient client, NavigatorContext navigatorContext)
        {
            _navigatorContext = navigatorContext;
            client.BaseAddress = new Uri("https://eve-scout.com");

            Client = client;
        }

        public async Task<IEnumerable<EveScoutDto>> GetEveScoutData(int systemId, string systemName)
        {
            var time = DateTime.Now;

            RemoveStaleData(time);

            //Query DB for data
            var systemData = _navigatorContext.EveScoutData.SingleOrDefault(x => x.Id == systemId);

            string eveScoutData = systemData?.EveScoutData;

            //If DB doesn't have data, ask eve scout
            if (eveScoutData == null)
            {
                var response = await Client.GetAsync($"api/wormholes?systemSearch={systemName}");

                response.EnsureSuccessStatusCode();

                eveScoutData = await response.Content.ReadAsStringAsync();
            }

            var data = JsonConvert.DeserializeObject<List<EveScoutDto>>(eveScoutData);
            if (systemData == null)
            {
                //Todo: Take into account if the wormhole expires before our cache time.
                systemData = new ScoutData
                {
                    CachedTime = time,
                    EveScoutData = eveScoutData,
                    Id = systemId,
                    SolarSystemName = systemName,
                };

                _navigatorContext.EveScoutData.Add(systemData);
                _navigatorContext.SaveChanges();
            }
            return data;
        }

        private void RemoveStaleData(DateTime time)
        {
            var cacheTime = time.AddMinutes(-5);
            var staleData = _navigatorContext.EveScoutData.Where(x => x.CachedTime < cacheTime);

            foreach (var scoutData in staleData)
            {
                _navigatorContext.EveScoutData.Remove(scoutData);
            }

            _navigatorContext.SaveChanges();
        }
    }
}
