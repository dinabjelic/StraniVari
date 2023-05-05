namespace StraniVari.Core.Entities
{
    public class VolunteerTrip:BaseEntity
    {
        public int VolunteerId { get; set; }
        public Volunteer Volunteer { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public int StatusId { get; set; }
        public TripStatus Status { get; set; }

    }
}
