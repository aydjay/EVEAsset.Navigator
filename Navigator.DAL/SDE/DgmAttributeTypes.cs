namespace Navigator.DAL.SDE
{
    public partial class DgmAttributeTypes
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string Description { get; set; }
        public int? IconId { get; set; }
        public double? DefaultValue { get; set; }
        public bool? Published { get; set; }
        public string DisplayName { get; set; }
        public int? UnitId { get; set; }
        public bool? Stackable { get; set; }
        public bool? HighIsGood { get; set; }
        public int? CategoryId { get; set; }
    }
}
