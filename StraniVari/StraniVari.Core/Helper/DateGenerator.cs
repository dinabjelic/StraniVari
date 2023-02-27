namespace StraniVari.Core.Helper
{
    public class DateGenerator
    {
        public static Random random = new Random();

        public static DateTime GenerateRandomDate(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return startDate + newSpan;
        }
    }
}
