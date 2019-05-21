using System.Collections.Generic;
using System.Threading.Tasks;
using EVEStandard.Enumerations;
using EVEStandard.Models;

namespace EVEAsset.Navigator.Interfaces
{
    public interface IUniverseCache
    {
        Task<int> PopulateIdCache(IEnumerable<int> universeIds);

        Task<string> GetNameForId(int id);

        void PrepopulateData(IEnumerable<UniverseIdsToNames> solarSystems);

        IEnumerable<UniverseIdsToNames> GetAllByCategory(CategoryEnum category);
    }
}