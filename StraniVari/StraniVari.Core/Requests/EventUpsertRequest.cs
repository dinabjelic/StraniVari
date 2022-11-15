namespace StraniVari.Core.Requests
{
    public class EventUpsertRequest
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public int NumberOfChildren { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
