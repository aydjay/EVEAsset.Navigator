namespace Navigator.DAL.SDE
{
    public partial class WarCombatZones
    {
        public int CombatZoneId { get; set; }
        public string CombatZoneName { get; set; }
        public int? FactionId { get; set; }
        public int? CenterSystemId { get; set; }
        public string Description { get; set; }
    }
}
