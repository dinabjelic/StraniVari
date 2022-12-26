using System.ComponentModel.DataAnnotations.Schema;

namespace StraniVari.Core.Entities
{
    public class Notification:BaseEntity
    {
        public Event Event { get; set; }
        public int EventId { get; set; }

        public DayOfWeek? DayOfWeek { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MeetingPlace { get; set; }
        public string MeetingTheme { get; set; }
    }
}
