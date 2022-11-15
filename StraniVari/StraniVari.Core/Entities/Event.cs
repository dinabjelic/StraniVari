namespace StraniVari.Core.Entities
{
    public class Event:BaseEntity
    {
        public School Schools { get; set; }
        public int SchoolId { get; set; }

        public int NumberOfChildren { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
