using System;

namespace RedisWithCSharp.Global
{
    public static class Helpers
    {
        public static TimeSpan DateTimeToTimeSpan(DateTime date)
        {
            var defaultDate = new DateTime(1970, 1, 1);
            TimeSpan ts = new TimeSpan(date.Ticks - defaultDate.Ticks);

            return TimeSpan.FromSeconds(ts.TotalSeconds);
        }
    }
}
