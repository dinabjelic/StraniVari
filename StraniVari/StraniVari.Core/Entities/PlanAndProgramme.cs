namespace StraniVari.Core.Entities
{
    public class PlanAndProgramme:BaseEntity
    {
        public Event Event { get; set; }
        public int EventId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Activity { get; set; }
    }
}
