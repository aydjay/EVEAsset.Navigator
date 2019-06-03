namespace Navigator.DAL.SDE
{
    public partial class DgmExpressions
    {
        public int ExpressionId { get; set; }
        public int? OperandId { get; set; }
        public int? Arg1 { get; set; }
        public int? Arg2 { get; set; }
        public string ExpressionValue { get; set; }
        public string Description { get; set; }
        public string ExpressionName { get; set; }
        public int? ExpressionTypeId { get; set; }
        public int? ExpressionGroupId { get; set; }
        public int? ExpressionAttributeId { get; set; }
    }
}
