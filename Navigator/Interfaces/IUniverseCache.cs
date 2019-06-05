using System.Collections.Generic;
using System.Threading.Tasks;

namespace Navigator.Interfaces
{
    public interface IUniverseCache
    {
        Task<int> PopulateIdCache(IEnumerable<int> universeIds);

        Task<string> GetNameForId(int id);
    }
}