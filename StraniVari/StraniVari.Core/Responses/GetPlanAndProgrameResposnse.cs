namespace StraniVari.Core.Responses
{
    public class GetPlanAndProgrameResposnse
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime ActivityDateTime { get; set; }
        public string Activity { get; set; }
        public int StraniVariThemeId { get; set; }
        public string StraniVariTheme { get; set; }
    }
}
