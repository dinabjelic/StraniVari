namespace StraniVari.Core.Requests
{
    public class UpdateVolunteerAssignedToSchoolRequest
    {
        public int SchoolVolunteerId { get; set; }
        public bool TransportNeeded { get; set; }
    }
}
