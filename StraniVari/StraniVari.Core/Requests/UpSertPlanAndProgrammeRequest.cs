namespace StraniVari.Core.Requests
{
    public class UpSertPlanAndProgrammeRequest
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime ActivityDateTime { get; set; }
        public string Activity { get; set; }
        public int StraniVariThemeId { get; set; }
        public string StraniVariTheme { get; set; }
    }
}
