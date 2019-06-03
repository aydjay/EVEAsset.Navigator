namespace Navigator.DAL.SDE
{
    public partial class InvContrabandTypes
    {
        public int FactionId { get; set; }
        public int TypeId { get; set; }
        public double? StandingLoss { get; set; }
        public double? ConfiscateMinSec { get; set; }
        public double? FineByValue { get; set; }
        public double? AttackMinSec { get; set; }
    }
}
