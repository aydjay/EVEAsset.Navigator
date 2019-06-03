namespace Navigator.DAL.SDE
{
    public partial class RamAssemblyLineTypes
    {
        public int AssemblyLineTypeId { get; set; }
        public string AssemblyLineTypeName { get; set; }
        public string Description { get; set; }
        public double? BaseTimeMultiplier { get; set; }
        public double? BaseMaterialMultiplier { get; set; }
        public double? BaseCostMultiplier { get; set; }
        public double? Volume { get; set; }
        public int? ActivityId { get; set; }
        public double? MinCostPerHour { get; set; }
    }
}
