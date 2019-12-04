using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Navigator.Controllers
{
    public class AssetSafetyController : Controller
    {
        private readonly IHostingEnvironment _environment;

        public AssetSafetyController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index(string system)
        {
            var assetSafetyData = System.IO.File.ReadAllText(Path.Combine(_environment.WebRootPath,
                "staticData", "AssetSafetySystems.json"));
            //Build the table
            var systems = JsonConvert.DeserializeObject<List<AssetSafetySystemViewModel>>(assetSafetyData);
            systems = systems.OrderByDescending(x => x.SystemsServiced).ToList();
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
    }
}