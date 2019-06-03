namespace Navigator.DAL.SDE
{
    public partial class InvControlTowerResources
    {
        public int ControlTowerTypeId { get; set; }
        public int ResourceTypeId { get; set; }
        public int? Purpose { get; set; }
        public int? Quantity { get; set; }
        public double? MinSecurityLevel { get; set; }
        public int? FactionId { get; set; }
    }
}
