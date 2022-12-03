namespace StraniVari.Core.Requests
{
    public class InsertVolunteerToSchoolRequest
    {
        public int EventSchoolId { get; set; }
        public int[] Volunteers { get; set; }
    }
}
