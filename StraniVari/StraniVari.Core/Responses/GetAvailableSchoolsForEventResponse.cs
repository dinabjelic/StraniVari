namespace StraniVari.Core.Responses
{
    public class GetAvailableSchoolsForEventResponse
    {
        public int EventId { get; set; }
        public int SchoolEventId { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string SchoolCity { get; set; }
    }
}
