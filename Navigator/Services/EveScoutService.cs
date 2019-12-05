using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Navigator.Models;
using Newtonsoft.Json;

namespace Navigator.Services
{
    public class EveScoutService
    {
        public HttpClient Client { get; }

        public EveScoutService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://eve-scout.com");

            Client = client;
        }

        public async Task<IEnumerable<EveScoutDto>> GetEveScoutData(string systemName = "Jita")
        {
            var response = await Client.GetAsync($"api/wormholes?systemSearch={systemName}");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<EveScoutDto>>(responseString);
        }
    }
}
