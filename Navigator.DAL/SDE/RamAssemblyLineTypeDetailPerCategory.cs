namespace Navigator.DAL.SDE
{
    public partial class RamAssemblyLineTypeDetailPerCategory
    {
        public int AssemblyLineTypeId { get; set; }
        public int CategoryId { get; set; }
        public double? TimeMultiplier { get; set; }
        public double? MaterialMultiplier { get; set; }
        public double? CostMultiplier { get; set; }
    }
}
