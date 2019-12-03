using System.Collections.Generic;
using System.Linq;

namespace Navigator.Models
{
    public class LoyaltyRewardsViewModel 
    {
        public List<ItemDisplayWrapper> Offers;

        public LoyaltyRewardsViewModel(List<ItemDisplayWrapper> offers)
        {
            Offers = offers.OrderByDescending(x => x.WrappedModel.LpCost).ToList();
        }
    }
}