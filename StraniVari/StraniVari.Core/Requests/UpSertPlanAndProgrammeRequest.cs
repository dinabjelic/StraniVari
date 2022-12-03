namespace StraniVari.Core.Requests
{
    public class UpSertPlanAndProgrammeRequest
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Activity { get; set; }
        public int EventId { get; set; }
    }
}
