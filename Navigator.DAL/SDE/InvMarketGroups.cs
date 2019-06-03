namespace Navigator.DAL.SDE
{
    public partial class InvMarketGroups
    {
        public int MarketGroupId { get; set; }
        public int? ParentGroupId { get; set; }
        public string MarketGroupName { get; set; }
        public string Description { get; set; }
        public int? IconId { get; set; }
        public bool? HasTypes { get; set; }
    }
}
