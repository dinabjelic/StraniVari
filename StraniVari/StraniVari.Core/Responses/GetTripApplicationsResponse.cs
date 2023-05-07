namespace StraniVari.Core.Responses
{
    public class GetTripApplicationsResponse
    {
        public int VolunteerId { get; set; }
        public string VolunteerName { get; set; }
        public string VolunteerLastName { get; set; }
        public string Status { get; set; }
        public int StatusId { get; set; }
        public string Place { get; set; }
        public string EventName { get; set; }
    }
}
