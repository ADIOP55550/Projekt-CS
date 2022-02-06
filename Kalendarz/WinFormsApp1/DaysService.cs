using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz
{
    public class DaysService
    {
        private DaysService()
        {
        }

        private static DaysService? _instance;

        public static DaysService GetInstance()
        {
            return _instance ??= new DaysService();
        }

        public Dictionary<DateTime, HighlightInfo> GetHighlightInfosForMonth(int year, int month)
        {

            Dictionary<DateTime, HighlightInfo> result = new();

            // TODO: This is temporary, exchange this with Database access
            var rnd = new Random(year * 100 + month);

            foreach (var day in DateUtils.EachDay(
                         new DateTime(year, month, 1),
                         new DateTime(year, month, DateTime.DaysInMonth(year, month))
                     )
                    )
            {
                result.Add(day, HighlightInfo.Random(rnd));
            }

            return result;
        }

        public HighlightInfo GetHighlightInfoForDay(DateTime day)
        {
            // TODO: This is temporary, exchange this with Database access

            return HighlightInfo.Random(new Random((int) day.ToBinary()));
        }
    }
}