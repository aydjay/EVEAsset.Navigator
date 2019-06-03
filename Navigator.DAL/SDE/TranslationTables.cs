namespace Navigator.DAL.SDE
{
    public partial class TranslationTables
    {
        public string SourceTable { get; set; }
        public string DestinationTable { get; set; }
        public string TranslatedKey { get; set; }
        public int? TcGroupId { get; set; }
        public int? TcId { get; set; }
    }
}
