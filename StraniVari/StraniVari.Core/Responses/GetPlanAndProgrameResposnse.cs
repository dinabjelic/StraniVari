namespace StraniVari.Core.Responses
{
    public class GetPlanAndProgrameResposnse
    {
        public int Id { get; set; }
        public DayOfWeek? DayOfWeek { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Activity { get; set; }
        //public string EventName { get; set; }
        //public string StraniVariTheme { get; set; }
    }
}
