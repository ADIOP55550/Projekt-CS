namespace Kalendarz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);

            PrevMonthCalendar.MinDate = startDate.AddMonths(-1);
            PrevMonthCalendar.MaxDate = startDate.AddDays(-1);

            NextMonthCalendar.MaxDate = startDate.AddMonths(2).AddDays(-1);
            NextMonthCalendar.MinDate = startDate.AddMonths(1);
        }
    }
}