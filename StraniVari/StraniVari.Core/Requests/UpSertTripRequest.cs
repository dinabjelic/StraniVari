namespace StraniVari.Core.Requests
{
    public class UpSertTripRequest
    {
        public string Place { get; set; }
        public DateTime TripDateTime { get; set; }
        public int EventId { get; set; }
    }
}
