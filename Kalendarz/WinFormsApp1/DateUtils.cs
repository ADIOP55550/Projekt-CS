using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz
{
    public class DateUtils
    {
        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru, int interval = 1)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(interval))
                yield return day;
        }
    }
}