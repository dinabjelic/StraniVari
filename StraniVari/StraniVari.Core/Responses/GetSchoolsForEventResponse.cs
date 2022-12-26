namespace StraniVari.Core.Responses
{
    public class GetSchoolsForEventResponse
    {
        public int EventId { get; set; }
        public int SchoolEventId { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string SchoolCity { get; set; }
        public int NumberOfChildren { get; set; }
        //public string EventName { get; set; }
        //public string StraniVariTheme { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
    }
}
