namespace StraniVari.Core.Entities
{
    public class Trip:BaseEntity
    {
        public string Place { get; set; }
        public DateTime TripDateTime { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
