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

    public class DisplayWrapper<T>
    {
        public T WrappedModel;

        public DisplayWrapper(T wrappedModel)
        {
            WrappedModel = wrappedModel;
        }
    }


}