namespace StraniVari.Core.Requests
{
    public class VolunteerSchoolInsertRequest
    {
        public int[] Volunteers { get; set; }
        public int EventId { get; set; }
        public int SchoolId { get; set; }
    }
}
