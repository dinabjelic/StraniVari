namespace StraniVari.Core.Responses
{
    public class GetVolunteerShoolDetailsResponse
    {
        //public int SchoolId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShoolName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public bool TransportNeeded { get; set; }
        public int VolunteeringYear { get; set; }
    } 
}
