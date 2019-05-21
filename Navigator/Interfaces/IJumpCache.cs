using System.Threading.Tasks;

namespace EVEAsset.Navigator.Interfaces
{
    public interface IJumpCache
    {
        Task<int> PopulateJumpCache(int fromId, int toId);

        Task<int> GetJumpsDistance(int fromId, int toId);
    }
}