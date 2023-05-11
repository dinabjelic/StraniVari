namespace StraniVari.Core.Requests
{
    public class VolunteerTripStatusRequest
    {
        public int VolunteerId { get; set; }
        public int TripId { get; set; }

        public int StatusId { get; set; }
    }
}
