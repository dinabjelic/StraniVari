using System.Text.Json.Serialization;

namespace StraniVari.Common.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WeekDays
    {
        Monday=1, 
        Tuesday=2, 
        Wednesday=3, 
        Thursday=4, 
        Friday=5
    }
}
