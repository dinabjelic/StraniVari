namespace StraniVari.Core.Entities
{
    public class EventTrips:BaseEntity
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
