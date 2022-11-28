namespace StraniVari.Core.Entities
{
    public class PlanAndProgramme:BaseEntity
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime ActivityDateTime { get; set; }
        public string Activity { get; set; }

        public StraniVariTheme StraniVariTheme { get; set; }
        public int StraniVariThemeId { get; set; }
    }
}
