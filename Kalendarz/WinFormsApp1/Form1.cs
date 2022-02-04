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

            customCalendar1.DateChanged += (calendar, time) =>
            {
                PrevMonthCalendar.MaxDate = DateTime.MaxValue;
                PrevMonthCalendar.MinDate = time.AddMonths(-1);
                PrevMonthCalendar.MaxDate = time.AddDays(-1);

                NextMonthCalendar.MinDate = DateTime.UnixEpoch;
                NextMonthCalendar.MaxDate = time.AddMonths(2).AddDays(-1);
                NextMonthCalendar.MinDate = time.AddMonths(1);
            };
        }

        private void CurrMonthPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            customCalendar1.SelectedDay = DateTime.Today;
        }

        private void PrevMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            customCalendar1.SelectedDay = PrevMonthCalendar.SelectionStart;
        }

        private void NextMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            customCalendar1.SelectedDay = NextMonthCalendar.SelectionStart;
        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}