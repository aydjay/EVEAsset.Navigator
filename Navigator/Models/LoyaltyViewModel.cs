using System.Collections.Generic;
using System.Linq;
using EVEStandard.Models;
using Navigator.DAL.SDE;

namespace Navigator.Models
{
    public class LoyaltyViewModel
    {
        public readonly List<LoyaltyPointDisplayWrapper> LoyaltyPoints;

        public LoyaltyViewModel(List<LoyaltyPointDisplayWrapper> loyaltyPoints)
        {
            LoyaltyPoints = loyaltyPoints;
        }
    }

    public class LoyaltyPointDisplayWrapper
    {
        private InvUniqueNames npcCorpData;
        public int LoyaltyPointQuantity;
        public string CorpName => npcCorpData.ItemName;
        public string CorpID;

        public LoyaltyPointDisplayWrapper(InvUniqueNames npcCorpData, LoyaltyPoints lp)
        {
            this.npcCorpData = npcCorpData;
            CorpID = lp.CorporationId.ToString();
            this.LoyaltyPointQuantity = lp.Points;
        }
    }
}