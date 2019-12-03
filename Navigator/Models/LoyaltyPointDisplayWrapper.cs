using EVEStandard.Models;
using Navigator.DAL.SDE;

namespace Navigator.Models
{
    public class LoyaltyPointDisplayWrapper : DisplayWrapper<LoyaltyPoints>
    {
        private InvUniqueNames _npcCorpData;

        public int LoyaltyPointQuantity => WrappedModel.Points;

        public string CorpName => _npcCorpData.ItemName;

        public LoyaltyPointDisplayWrapper(InvUniqueNames npcCorpData, LoyaltyPoints lp) 
            : base(lp)
        {
            _npcCorpData = npcCorpData;
        }
    }
}