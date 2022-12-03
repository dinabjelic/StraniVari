namespace StraniVari.Core.Responses
{
    public class GetVolunteersForSchoolResponse
    {
        public int SchoolVolunteerId { get; set; }
        //public string SchoolName { get; set; }
        //public string SchoolAddress { get; set; }
        //public string SchoolCity { get; set; }
        public bool TransportNeeded { get; set; }
        //public string EventName { get; set; }
        //public string StraniVariTheme { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VolunteerAddress { get; set; }
        public string VolunteerCity { get; set; }
    }
}
