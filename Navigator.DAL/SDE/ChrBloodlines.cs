namespace Navigator.DAL.SDE
{
    public partial class ChrBloodlines
    {
        public int BloodlineId { get; set; }
        public string BloodlineName { get; set; }
        public int? RaceId { get; set; }
        public string Description { get; set; }
        public string MaleDescription { get; set; }
        public string FemaleDescription { get; set; }
        public int? ShipTypeId { get; set; }
        public int? CorporationId { get; set; }
        public int? Perception { get; set; }
        public int? Willpower { get; set; }
        public int? Charisma { get; set; }
        public int? Memory { get; set; }
        public int? Intelligence { get; set; }
        public int? IconId { get; set; }
        public string ShortDescription { get; set; }
        public string ShortMaleDescription { get; set; }
        public string ShortFemaleDescription { get; set; }
    }
}
