namespace Navigator.DAL.SDE
{
    public partial class MapConstellationJumps
    {
        public int? FromRegionId { get; set; }
        public int FromConstellationId { get; set; }
        public int ToConstellationId { get; set; }
        public int? ToRegionId { get; set; }
    }
}
