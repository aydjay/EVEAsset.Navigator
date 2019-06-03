namespace Navigator.DAL.SDE
{
    public partial class InvTypes
    {
        public int TypeId { get; set; }
        public int? GroupId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public double? Mass { get; set; }
        public double? Volume { get; set; }
        public double? Capacity { get; set; }
        public int? PortionSize { get; set; }
        public int? RaceId { get; set; }
        public decimal? BasePrice { get; set; }
        public bool? Published { get; set; }
        public int? MarketGroupId { get; set; }
        public int? IconId { get; set; }
        public int? SoundId { get; set; }
        public int? GraphicId { get; set; }
    }
}
