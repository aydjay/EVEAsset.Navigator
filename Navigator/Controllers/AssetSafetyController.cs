using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Navigator.Models;
using Navigator.Services;
using Newtonsoft.Json;

namespace Navigator.Controllers
{
    public class AssetSafetyController : Controller
    {
        private readonly IHostingEnvironment _environment;
        private readonly EveScoutService _eveScout;
        
        public AssetSafetyController(IHostingEnvironment environment, EveScoutService eveScout)
        {
            _environment = environment;
            _eveScout = eveScout;
        }

        public async Task<IActionResult> Index()
        {
            var assetSafetyData = System.IO.File.ReadAllText(Path.Combine(_environment.WebRootPath,
                "staticData", "AssetSafetySystems.json"));
            //Build the table
            var systems = JsonConvert.DeserializeObject<List<AssetSafetySystemViewModel>>(assetSafetyData);
            systems = systems.OrderByDescending(x => x.SystemsServiced).ToList();

            foreach (var system in systems)
            {
                system.EveScoutData = await _eveScout.GetEveScoutData(system.SolarSystemName); 
            }

            return View(systems);
        }
    }

    public class AssetSafetySystemViewModel
    {
        [JsonProperty("solarSystemID")]
        public int SolarSystemId { get; set; }

        [JsonProperty("solarSystemName")]
        public string SolarSystemName { get; set; }

        [JsonProperty("regionID")]
        public int RegionId { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("systemsServiced")]
        public int SystemsServiced { get; private set; }

        public IEnumerable<EveScoutDto> EveScoutData { get; set; }

        public int NearestSystem => EveScoutData.Where(x => x.Jumps > 0)
                                                .OrderBy(x => x.Jumps)
                                                .FirstOrDefault()?.Jumps ?? 0;
    }
}