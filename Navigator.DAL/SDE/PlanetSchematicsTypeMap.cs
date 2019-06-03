namespace Navigator.DAL.SDE
{
    public partial class PlanetSchematicsTypeMap
    {
        public int SchematicId { get; set; }
        public int TypeId { get; set; }
        public int? Quantity { get; set; }
        public bool? IsInput { get; set; }
    }
}
