using System;
using System.Globalization;

namespace Extension_Method.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisobj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisobj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }

        }
    }
}
