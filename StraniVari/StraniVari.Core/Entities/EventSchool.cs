namespace StraniVari.Core.Entities
{
    public class EventSchool:BaseEntity
    {
        public School School { get; set; }
        public int SchoolId { get; set; }

        public Event Event { get; set; }
        public int EventId { get; set; }

        public int NumberOfChildren { get; set; }

        public ICollection<SchoolVolunteer> SchoolVolunteers { get; set; }
    }
}
