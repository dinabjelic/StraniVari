namespace StraniVari.Core.Responses
{
    public class GetEventSchoolsVolunteersResponse
    {
        public int VolunteerId { get; set; }
        public int SchoolVolunteerId { get; set; }
        public bool TransportNeeded { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VolunteerAddress { get; set; }
        public string VolunteerCity { get; set; }
        public bool IsChecked { get; set; }
    }
}
