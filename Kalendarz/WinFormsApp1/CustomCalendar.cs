using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kalendarz
{
    public partial class CustomCalendar : UserControl
    {
        private static readonly string[] monthNames = new string[]
        {
            "", "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień",
            "Październik",
            "Listopad", "Grudzień"
        };

        /// <summary>
        /// Date change event sentinel type
        /// </summary>
        private static readonly object s_dateChanged = new();

        private readonly static int daysCount = 42;
        private int _currMonth = DateTime.Today.Month;
        private int _currYear = DateTime.Today.Year;
        private DateTime? _selectedDay = null;

        private CalendarDay[] _days = new CalendarDay[daysCount];

        public HashSet<DateTime> dottedDays = new();
        public HashSet<DateTime> starredDays = new();

        public DateTime? SelectedDay
        {
            get => _selectedDay;
            set
            {
                _selectedDay = value;

                if (value != null)
                    if (!((DateTime) value).Month.Equals(_currMonth))
                    {
                        CurrMonth = ((DateTime) value).Month;
                        CurrYear = ((DateTime) value).Year;
                    }

                Invalidate();
            }
        }

        public int CurrMonth
        {
            get => _currMonth;
            set
            {
                _currMonth = value;
                while (_currMonth > 12)
                {
                    _currMonth -= 12;
                    _currYear++;
                }

                while (_currMonth < 1)
                {
                    _currMonth += 12;
                    _currYear--;
                }

                this.monthLabel.Text = monthNames[_currMonth] + " " + this.CurrYear;

                ((EventHandler<DateTime>?) Events[s_dateChanged])?.Invoke(this, new DateTime(this._currYear, this._currMonth, 1));

                this.InvalidateAllDays();
                this.Invalidate();
            }
        }

        public int CurrYear
        {
            get => _currYear;
            set
            {
                _currYear = value;
                this.monthLabel.Text = monthNames[_currMonth] + " " + this.CurrYear;

                ((EventHandler<DateTime>?) Events[s_dateChanged])?.Invoke(this, new DateTime(this._currYear, this._currMonth, 1));

                this.InvalidateAllDays();
                this.Invalidate();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler<DateTime>? DateChanged
        {
            add => Events.AddHandler(s_dateChanged, value);
            remove => Events.RemoveHandler(s_dateChanged, value);
        }


        private void InvalidateAllDays()
        {
            foreach (var calendarDay in this._days)
            {
                calendarDay.Invalidate();
            }
        }

        public DayOfWeek FirstDayOfWeek { get; set; } = DayOfWeek.Monday;

        public CustomCalendar()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                var day = (DayOfWeek) ((i + (int) FirstDayOfWeek) % 7);

                var label = new Label();
                label.Font = new Font(label.Font.Name, label.Font.Size + 2);
                label.Text = day.ToString();
                calendarGrid.Controls.Add(label);
                // calendarGrid.SetColumn(label, i);
                // calendarGrid.SetRow(label, 0);
            }

            var firstDay = new DateTime(this.CurrYear, this.CurrMonth, 1);
            var addDaysFromPrevMonth = ((int) firstDay.DayOfWeek) % 7;
            var singleLabelSize = new Size(calendarGrid.GetColumnWidths()[0], calendarGrid.GetRowHeights()[1]);

            for (int i = 0; i < daysCount; i++)
            {
                var day = firstDay.AddDays(i - addDaysFromPrevMonth);
                var calendarDay = new CalendarDay(new Font(SystemFonts.DefaultFont.Name, 18F), day);
                calendarDay.Size = singleLabelSize;
                calendarDay.Click += (sender, args) =>
                    SelectedDay = ((CalendarDay) sender!).Day;
                calendarDay.DoubleClick +=
                    (indicator, args) =>
                    {
                        dottedDays.Add(((CalendarDay) indicator!).Day);
                        Invalidate();
                    };

                calendarDay.MouseWheel +=
                    (indicator, args) =>
                    {
                        starredDays.Add(((CalendarDay) indicator!).Day);
                        Invalidate();
                    };

                _days[i] = calendarDay;
                calendarGrid.Controls.Add(calendarDay);
                // calendarGrid.SetColumn(calendarDay, i - (i / 7) * 7);
                // calendarGrid.SetRow(calendarDay, i / 7 + 1);
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var firstDay = new DateTime(this.CurrYear, this.CurrMonth, 1);

            // 7 is added to prevent negative numbers which screw with the % operator
            var addDaysFromPrevMonth = ((int) firstDay.DayOfWeek - (int) FirstDayOfWeek + 7) % 7;

            SuspendLayout();

            for (int i = 0; i < daysCount; i++)
            {
                var calendarDay = _days[i];

                var day = firstDay.AddDays(i - addDaysFromPrevMonth);
                _days[i].Day = day;

                calendarDay.Text = day.Day.ToString();

                calendarDay.BorderColor =
                    day.Equals(SelectedDay) ? Color.Blue : day.Equals(DateTime.Today) ? Color.Gray : Color.Transparent;
                calendarDay.CircleColor =
                    dottedDays.Contains(day) ? Color.MediumPurple : Color.Transparent;
                calendarDay.CircleInnerColor =
                    starredDays.Contains(day) ? Color.Goldenrod : Color.Transparent;

                calendarDay.IsLowlighted = !day.Month.Equals(_currMonth);
            }

            ResumeLayout();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.CurrMonth--;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.CurrMonth++;
        }
    }
}