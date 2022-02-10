using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalendarz.Db;
using Microsoft.EntityFrameworkCore;

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

            var from = new DateTime(year, month, 1);
            var to = from.AddMonths(1).AddDays(-1);


            var entries = cc.Entries.Include(e => e.Tags)
                .Where(d => d.Date >= from && d.Date <= to)
                .OrderBy(d => d.Date)
                .ToList();


            foreach (var entry in entries)
                result.Add(entry.Date, entry.HighlightInfo);

            return result;
        }

        public HighlightInfo GetHighlightInfoForDay(DateTime day)
        {
            using CalendarContext cc = new();

            Debug.WriteLine("Getting highlihtInfo for day " + day.ToShortDateString());

            var elt = cc.Entries.Include(e => e.Tags)
                .Where(d => d.Date == day)
                .AsEnumerable()
                .FirstOrDefault(new Entry());

            return elt != null ? elt.HighlightInfo : new HighlightInfo();
        }


        public Entry GetDayEntry(DateTime date)
        {
            using CalendarContext cc = new CalendarContext();

            Entry elt = cc.Entries.Include(e => e.Tags)
                .Where(d => d.Date == date).AsEnumerable().FirstOrDefault(
                    new Entry
                    {
                        Date = date
                    });
            return elt;
        }

        public void SaveDayEntry(Entry entry)
        {
            using CalendarContext cc = new CalendarContext();
            var has = cc.Entries.Any(d => d.Id == entry.Id);

            if (entry.Content == "")
                entry.IsDone = false;

            if (has)
            {
                var idList = entry.Tags.Select(t => t.Id).ToList();
                cc.Tags.RemoveRange(
                    cc.Tags
                        .Where(t => t.EntryId == entry.Id)
                        .Where(t => !idList.Contains(t.Id))
                );
                // cc.SaveChanges();

                cc.Entries.Update(entry);
            }

            else
            {
                if (entry.Content == "" && entry.Tags.Count == 0) return;
                cc.Entries.Add(entry);
            }


            cc.SaveChanges();
        }

        public Dictionary<DateTime, HighlightInfo> GetHighlightInfosForMonthAndSurroundingWeeks(int currYear,
            int currMonth)
        {
            Dictionary<DateTime, HighlightInfo> result = new();

            var from = new DateTime(currYear, currMonth, 1).AddDays(-7);
            var to = new DateTime(currYear, currMonth, 1).AddMonths(1).AddDays(15);

            using CalendarContext cc = new();

            var entries = cc.Entries.Include(e => e.Tags).Where(
                    d => d.Date > from && d.Date < to
                )
                .OrderBy(d => d.Date)
                .ToList();


            foreach (var entry in entries)
                result.Add(entry.Date, entry.HighlightInfo);

            return result;
        }
    }
}