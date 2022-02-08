using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalendarz.Db;

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

            using CalendarContext cc = new CalendarContext();

            var entries = cc.Entries.Where(d => d.Date.Year == year && d.Date.Month == month).OrderBy(d => d.Date)
                .ToList();


            foreach (var entry in entries)
                result.Add(entry.Date, entry.HighlightInfo);

            return result;
        }

        public HighlightInfo GetHighlightInfoForDay(DateTime day)
        {
            using CalendarContext cc = new();

            var elt = cc.Entries.AsEnumerable().Where(d => d.Date == day).FirstOrDefault(new Entry());

            return elt != null ? elt.HighlightInfo : new HighlightInfo();
        }


        public Entry GetDayEntry(DateTime date)
        {
            using CalendarContext cc = new CalendarContext();
            Entry elt = cc.Entries.AsEnumerable().Where(d => d.Date == date).FirstOrDefault(new Entry
            {
                Date = date
            });
            return elt;
        }

        public void SaveDayEntry(Entry entry)
        {
            using CalendarContext cc = new CalendarContext();
            var has = cc.Entries.AsQueryable().Any(d => d.Id == entry.Id);

            if (has) cc.Entries.Update(entry);
            else
            {
                if (entry.Content == "") return;
                cc.Entries.Add(entry);
            }


            cc.SaveChanges();
        }
    }
}