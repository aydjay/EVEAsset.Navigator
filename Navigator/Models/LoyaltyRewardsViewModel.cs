using System.Collections.Generic;
using System.Linq;
using EVEStandard.Models;
using Navigator.DAL.SDE;

namespace Navigator.Models
{
    public class LoyaltyRewardsViewModel 
    {
        public List<LoyaltyStoreOfferDisplayWrapper> Offers;

        public LoyaltyRewardsViewModel(List<LoyaltyStoreOfferDisplayWrapper> offers)
        {
            Offers = offers.OrderByDescending(x => x.WrappedModel.LpCost).ToList();
        }
    }

    public class LoyaltyStoreOfferDisplayWrapper : DisplayWrapper<LoyaltyStoreOffer>
    {
        private InvTypes _itemData;

        public string ItemName => _itemData.TypeName;

        public LoyaltyStoreOfferDisplayWrapper(InvTypes itemData, LoyaltyStoreOffer offer)
            : base(offer)
        {
            _itemData = itemData;
        }
    }
}