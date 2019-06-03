namespace Navigator.DAL.SDE
{
    public partial class RamAssemblyLineStations
    {
        public int StationId { get; set; }
        public int AssemblyLineTypeId { get; set; }
        public int? Quantity { get; set; }
        public int? StationTypeId { get; set; }
        public int? OwnerId { get; set; }
        public int? SolarSystemId { get; set; }
        public int? RegionId { get; set; }
    }
}
