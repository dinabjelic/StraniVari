namespace StraniVari.Core.Requests
{
    public class UpdateTripRequest
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public DateTime TripDateTime { get; set; }
    }
}
