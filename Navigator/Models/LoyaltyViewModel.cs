using System.Collections.Generic;
using System.Linq;

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
}