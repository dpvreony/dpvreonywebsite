using System.Globalization;
using NodaTime;

namespace DPVreony.Website.Features.Articles
{
    public static class LocalDateExtensions
    {
        public static string ToYearMonthDayString(this LocalDate instance)
        {
            return instance.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
        }
    }
}
