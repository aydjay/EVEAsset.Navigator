using EVEStandard.Models;
using Navigator.DAL.SDE;

namespace Navigator.Models
{
    public class ItemDisplayWrapper : DisplayWrapper<LoyaltyStoreOffer>
    {
        private InvTypes _itemData;

        public string ItemName => _itemData.TypeName;

        public ItemDisplayWrapper(InvTypes itemData, LoyaltyStoreOffer offer)
            : base(offer)
        {
            _itemData = itemData;
        }
    }
}