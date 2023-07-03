namespace StraniVari.Core.Requests
{
    public class SchoolVolunteerMaterialRequest
    {
        public int SchoolId { get; set; }
        public int EventId { get; set; }
        public int[] Materials { get; set; }
        public int[] Volunteers { get; set; }
    }
}
