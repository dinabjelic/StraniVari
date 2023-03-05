namespace StraniVari.Core.Entities
{
    public class SchoolVolunteer:BaseEntity
    {
        public EventSchool EventSchool { get; set; }
        public int EventSchoolId { get; set; }

        public Volunteer Volunteer { get; set; }
        public int VolunteerId { get; set; }

        public bool TransportNeeded { get; set; }
    }
}
