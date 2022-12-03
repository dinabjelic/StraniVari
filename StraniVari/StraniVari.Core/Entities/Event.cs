namespace StraniVari.Core.Entities
{
    public class Event:BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StraniVariTheme { get; set; }
    }
}
