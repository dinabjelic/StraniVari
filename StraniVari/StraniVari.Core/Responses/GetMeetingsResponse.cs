namespace StraniVari.Core.Responses
{
    public class GetMeetingsResponse
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MeetingPlace { get; set; }
        public string MeetingTheme { get; set; }
        public int VolunteeringYear { get; set; }
    }
}
