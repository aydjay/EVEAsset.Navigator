using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Navigator.Controllers
{
    public class AssetSafetyController : Controller
    {
        private readonly IHostingEnvironment _environment;

        //private List<AssetSafetySystem> assetSafetySystems = new List<AssetSafetySystem>();
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
    }
}

/*[{"regionID":10000044,"regionName":"Solitude","solarSystemName":"Agaullores","solarSystemID":30003600},{"regionID":10000044,"regionName":"Solitude","solarSystemName":"Toustain","solarSystemID":30003606},{"regionID":10000042,"regionName":"Metropolis","solarSystemName":"Odebeinn","solarSystemID":30003470},{"regionID":10000042,"regionName":"Metropolis","solarSystemName":"Konora","solarSystemID":30003471},{"regionID":10000002,"regionName":"The Forge","solarSystemName":"Obe","solarSystemID":30000205},{"regionID":10000002,"regionName":"The Forge","solarSystemName":"Otitoh","solarSystemID":30000171},{"regionID":10000048,"regionName":"Placid","solarSystemName":"Chardalane","solarSystemID":30003834},{"regionID":10000043,"regionName":"Domain","solarSystemName":"Misaba","solarSystemID":30003563},{"regionID":10000043,"regionName":"Domain","solarSystemName":"Sieh","solarSystemID":30003557},{"regionID":10000020,"regionName":"Tash-Murkon","solarSystemName":"Saminer","solarSystemID":30001721},{"regionID":10000016,"regionName":"Lonetrek","solarSystemName":"Daras","solarSystemID":30001420},{"regionID":10000016,"regionName":"Lonetrek","solarSystemName":"Iitanmadan","solarSystemID":30001422},{"regionID":10000016,"regionName":"Lonetrek","solarSystemName":"Hakonen","solarSystemID":30001448},{"regionID":10000016,"regionName":"Lonetrek","solarSystemName":"Anin","solarSystemID":30001439},{"regionID":10000069,"regionName":"Black Rise","solarSystemName":"Villasen","solarSystemID":30045309},{"regionID":10000028,"regionName":"Molden Heath","solarSystemName":"Egbinger","solarSystemID":30002420},{"regionID":10000028,"regionName":"Molden Heath","solarSystemName":"Skarkon","solarSystemID":30002411},{"regionID":10000054,"regionName":"Aridia","solarSystemName":"Hophib","solarSystemID":30004309},{"regionID":10000001,"regionName":"Derelik","solarSystemName":"Podion","solarSystemID":30000019},{"regionID":10000001,"regionName":"Derelik","solarSystemName":"Faspera","solarSystemID":30000044},{"regionID":10000049,"regionName":"Khanid","solarSystemName":"Irmalin","solarSystemID":30003935},{"regionID":10000049,"regionName":"Khanid","solarSystemName":"Gehi","solarSystemID":30003897}]
*/