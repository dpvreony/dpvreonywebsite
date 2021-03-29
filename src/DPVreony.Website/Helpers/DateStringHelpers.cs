using System;

namespace DPVreony.Website.Helpers
{
    public static class DateStringHelpers
    {
        public static string GetFormattedDateDuration(DateTime startDate, DateTime? endDate)
        {
            const string OutputFormat = "MM/yyyy";
            var result = startDate.ToString(OutputFormat) + " - ";

            if (!endDate.HasValue)
            {
                result += "Ongoing";
            } else
            {
                result += endDate.Value.ToString(OutputFormat);
            }

            return result;
        }

    }
}
