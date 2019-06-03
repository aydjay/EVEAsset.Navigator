namespace Navigator.DAL.SDE
{
    public partial class InvTypeReactions
    {
        public int ReactionTypeId { get; set; }
        public bool Input { get; set; }
        public int TypeId { get; set; }
        public int? Quantity { get; set; }
    }
}
