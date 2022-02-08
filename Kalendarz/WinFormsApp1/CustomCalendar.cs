using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kalendarz
{
    public partial class CustomCalendar : UserControl
    {
        /// <summary>
        /// Month change event sentinel type
        /// </summary>
        private static readonly object s_monthChanged = new();

        /// <summary>
        /// Selected day change event sentinel type
        /// </summary>
        private static readonly object s_selectedDayChanged = new();

        private readonly static int daysCount = 42;
        private int _currMonth = DateTime.Today.Month;
        private int _currYear = DateTime.Today.Year;
        private CalendarDay? _selectedDay = null;
        private readonly CalendarDay[] _days = new CalendarDay[daysCount];
        private Dictionary<DateTime, HighlightInfo> _highlightInfos = new();

        public void SelectDay(DateTime day)
        {
            this._currMonth = day.Month;
            this.CurrYear = day.Year;
            SelectedDay = _days.FirstOrDefault(d => d != null && d.Day.Equals(day), null);
        }

        public CalendarDay? GetCalendarDayByDate(DateTime day)
        {
            return this._days.SingleOrDefault(d => d.Day.Equals(day), null);
        }

        public CalendarDay? SelectedDay
        {
            get => _selectedDay;
            private set
            {
                if (_selectedDay != null)
                    // Deselect previous day
                    _selectedDay.IsSelected = false;

                if (value != null)
                {
                    // If a day outside current month is selected, then move to that day's month
                    if (!value.Day.Month.Equals(_currMonth))
                    {
                        SelectDay(value.Day);
                        return;
                    }
                }

                ((EventHandler<CustomDateChangeEventArgs>?) Events[s_selectedDayChanged])?.Invoke(this,
                    new CustomDateChangeEventArgs
                    {
                        Current = _selectedDay?.Day,
                        Next = value?.Day
                    }
                );

                // Update current value
                _selectedDay = value;


                if (_selectedDay != null)
                    // And set it's IsSelected value
                    _selectedDay.IsSelected = true;
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


                this.monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_currMonth) + " " +
                                       this.CurrYear;

                this.SelectedDay = null;

                ((EventHandler<DateTime>?) Events[s_monthChanged])?.Invoke(this,
                    new DateTime(this._currYear, this._currMonth, 1));

                _highlightInfos.Clear();
                this._highlightInfos =
                    DaysService.GetInstance().GetHighlightInfosForMonth(this.CurrYear, this.CurrMonth);

                UpdateDaysNumbers();
            }
        }

        public void ReloadDay(DateTime? day)
        {
            if (day == null)
                return;

            var cDay = this.GetCalendarDayByDate((DateTime) day);
            if (cDay != null)
                cDay.HighlightInfo = DaysService.GetInstance().GetHighlightInfoForDay((DateTime) day);
        }

        public int CurrYear
        {
            get => _currYear;
            set
            {
                _currYear = value;
                this.monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_currMonth) + " " +
                                       this.CurrYear;

                this.SelectedDay = null;


                ((EventHandler<DateTime>?) Events[s_monthChanged])?.Invoke(this,
                    new DateTime(this._currYear, this._currMonth, 1));

                _highlightInfos.Clear();
                _highlightInfos =
                    DaysService.GetInstance().GetHighlightInfosForMonth(this.CurrYear, this.CurrMonth);


                UpdateDaysNumbers();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler<DateTime>? MonthChanged
        {
            add => Events.AddHandler(s_monthChanged, value);
            remove => Events.RemoveHandler(s_monthChanged, value);
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler<CustomDateChangeEventArgs>? SelectedDayChanged
        {
            add => Events.AddHandler(s_selectedDayChanged, value);
            remove => Events.RemoveHandler(s_selectedDayChanged, value);
        }


        public DayOfWeek FirstDayOfWeek { get; set; } = DayOfWeek.Monday;

        public CustomCalendar()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            CreateDaysNamesLabels();
            CreateDaysElements();
        }

        private void CreateDaysNamesLabels()
        {
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
        }

        private void CreateDaysElements()
        {
            var firstDay = new DateTime(this.CurrYear, this.CurrMonth, 1);
            var addDaysFromPrevMonth = ((int) firstDay.DayOfWeek) % 7;
            var singleLabelSize = new Size(calendarGrid.GetColumnWidths()[0], calendarGrid.GetRowHeights()[1]);

            for (int i = 0; i < daysCount; i++)
            {
                var day = firstDay.AddDays(i - addDaysFromPrevMonth);
                var calendarDay = new CalendarDay(new Font(SystemFonts.DefaultFont.Name, 18F), day)
                {
                    Size = singleLabelSize
                };
                calendarDay.BorderThickness = 3;

                calendarDay.DoubleClick +=
                    (indicator, args) =>
                    {
                        ((CalendarDay) indicator!).HighlightInfo += new HighlightInfo
                        {
                            IndicatorColor = Color.MediumPurple
                        };
                    };

                calendarDay.MouseDown += (sender, args) => { SelectedDay = (CalendarDay) sender!; };

                calendarDay.MouseWheel +=
                    (indicator, args) =>
                    {
                        ((CalendarDay) indicator!).HighlightInfo +=
                            new HighlightInfo
                            {
                                IndicatorBorderColor = Color.Goldenrod
                            };
                    };

                _days[i] = calendarDay;
                calendarGrid.Controls.Add(calendarDay);
            }
        }

        private void UpdateDaysNumbers()
        {
            var firstDay = new DateTime(this.CurrYear, this.CurrMonth, 1);
            // 7 is added to prevent negative numbers which screw with the % operator
            var addDaysFromPrevMonth = ((int) firstDay.DayOfWeek - (int) FirstDayOfWeek + 7) % 7;
            var numDaysInMonth = DateTime.DaysInMonth(CurrYear, CurrMonth);

            this.SuspendLayout();

            for (int i = 0; i < daysCount; i++)
            {
                var calendarDay = _days[i];

                var day = firstDay.AddDays(i - addDaysFromPrevMonth);
                _days[i].Day = day;

                calendarDay.HighlightInfo =
                    _highlightInfos.ContainsKey(day)
                        ? _highlightInfos[day]
                        : DaysService.GetInstance().GetHighlightInfoForDay(day); // new HighlightInfo();
                calendarDay.IsLowlighted = i >= numDaysInMonth + addDaysFromPrevMonth || i < addDaysFromPrevMonth;
                // Override border color if the day is current_day or is selected
                calendarDay.BorderColor =
                    CalculateBorderColor(calendarDay, calendarDay.BorderColor);
            }

            this.ResumeLayout();
        }

        private Color CalculateBorderColor(CalendarDay day, Color? defaultColor = null)
        {
            return day.Day.Equals(DateTime.Today) ? Color.Gray : defaultColor ?? Color.Transparent;
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