namespace StraniVari.Core.Entities
{
    public class SchoolVolunteer: BaseEntity
    {
        public int VolunteerId { get; set; }
        public Volunteer Volunteers { get; set; }

        public int SchoolId { get; set; }
        public School Schools { get; set; }

        public bool TransportNeeded { get; set; }
        public int  VolunteeringYear { get; set; }
    }
}
