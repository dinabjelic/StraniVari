namespace StraniVari.Core.Requests
{
    public class VolunteerSchoolDeleteRequest
    {
        public int SchoolId { get; set; }
        //public List<VolunteerDeleteDto> Volunteers { get; set; }
        public int VolunteerId { get; set; }
        public int VolunteeringYear { get; set; }
    }
}
