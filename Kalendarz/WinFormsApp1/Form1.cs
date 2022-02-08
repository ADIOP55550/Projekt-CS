using System.Diagnostics;
using Kalendarz.Db;
using Markdig;


namespace Kalendarz
{
    public partial class Form1 : Form
    {
        private readonly WebBrowser _webBrowser;
        private readonly string _styles = Properties.Resources.MarkdownGithubThemeLight;
        private readonly string _stylesDark = Properties.Resources.MarkdownGithubThemeDark;
        private bool _useDarkTheme;

        public bool UseDarkTheme
        {
            get => _useDarkTheme;
            set
            {
                _useDarkTheme = value;
                if (_useDarkTheme)
                {
                    _webBrowser.BackColor = Color.Black;
                    editorTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1117");
                    editorTextBox.ForeColor = Color.White;
                }
                else
                {
                    editorTextBox.BackColor = Color.White;
                    editorTextBox.ForeColor = Color.Black;
                    _webBrowser.BackColor = Color.White;
                }

                TranspileMarkdown(editorTextBox.Text);
            }
        }

        private Action SaveCallbackDebounced;
        private DateTime? _selectedDate;

        private void SaveNote(DateTime? day)
        {
            // save to Db

            if (day == null)
                return;

            Invoke(() =>
            {
                var entry = DaysService.GetInstance().GetDayEntry((DateTime)day);
                entry.Content = editorTextBox.Text;
                DaysService.GetInstance().SaveDayEntry(entry);

                customCalendar1.ReloadDay(entry.Date);
            });
        }

        private void SaveCurrentNote()
        {
            this.SaveNote(this._selectedDate);
        }

        public Form1()
        {
            InitializeComponent();
            var now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);

            SaveCallbackDebounced = Util.Debounce(this.SaveCurrentNote, 1000);

            this._webBrowser = new WebBrowser();
            _webBrowser.Dock = DockStyle.Fill;

            editorSplit.Panel2.Controls.Add(_webBrowser);

            // customCalendar1.FirstDayOfWeek = DayOfWeek.Sunday;

            PrevMonthCalendar.MinDate = startDate.AddMonths(-1);
            PrevMonthCalendar.MaxDate = startDate.AddDays(-1);

            NextMonthCalendar.MaxDate = startDate.AddMonths(2).AddDays(-1);
            NextMonthCalendar.MinDate = startDate.AddMonths(1);

            customCalendar1.MonthChanged += OnCustomCalendarMonthChanged;
            customCalendar1.SelectedDayChanged += OnCustomCalendarSelectedDayChanged;

            TranspileMarkdown("");
        }

        private void OnCustomCalendarSelectedDayChanged(object? sender, CustomDateChangeEventArgs e)
        {
            if (e.Current != null)
                SaveNote(e.Current);

            Entry? entry = null;

            if (e.Next != null)
                entry = LoadNewNote((DateTime)e.Next);
            else
                ClearTextField();

            this._selectedDate = e.Next;

            customCalendar1.ReloadDay(e.Next);

        }

        private void ClearTextField()
        {
            editorTextBox.Clear();
            TranspileMarkdown("");
        }

        private Entry LoadNewNote(DateTime day)
        {
            var entry = DaysService.GetInstance().GetDayEntry(day);
            editorTextBox.Text = entry.Content;
            TranspileMarkdown(editorTextBox.Text);
            return entry;
        }

        private void OnCustomCalendarMonthChanged(object calendar, DateTime time)
        {
            PrevMonthCalendar.MaxDate = DateTime.MaxValue;
            PrevMonthCalendar.MinDate = time.AddMonths(-1);
            PrevMonthCalendar.MaxDate = time.AddDays(-1);

            NextMonthCalendar.MinDate = DateTime.UnixEpoch;
            NextMonthCalendar.MaxDate = time.AddMonths(2).AddDays(-1);
            NextMonthCalendar.MinDate = time.AddMonths(1);
        }

        private void CurrMonthPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            customCalendar1.SelectDay(DateTime.Today);
        }

        private void PrevMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            customCalendar1.SelectDay(PrevMonthCalendar.SelectionStart);
        }

        private void NextMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            customCalendar1.SelectDay(NextMonthCalendar.SelectionStart);
        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.SaveCallbackDebounced();
            TranspileMarkdown(((RichTextBox)sender).Text);
        }

        private void TranspileMarkdown(string text)
        {
            var html = Markdown.ToHtml(text);
            html = "<html>" +
                   "<body>" +
                   "<style lang=\"css\">" +
                   "body{" +
                   "width:100vw;" +
                   "height:100vh;" +
                   "background:" + (UseDarkTheme ? "#0D1117" : "#ffffff") + ";" +
                   "}" +
                   (UseDarkTheme ? _stylesDark : _styles) +
                   "</style>" +
                   "<div class=\"markdown-body\">" +
                   html +
                   "</div>" +
                   "</body>" +
                   "</html>";
            // html = System.Security.SecurityElement.Escape(html);
            _webBrowser.DocumentText = html;
        }

        private void themeSwitchBtn_Click(object sender, EventArgs e)
        {
            this.UseDarkTheme = !this.UseDarkTheme;
        }



        /*    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {
                flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel1.AutoScroll = true;
                VerticalScroll.Visible = false;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                panel2.Visible = true;
            }

            private void confirmButton_Click(object sender, EventArgs e)
            {
                CustomTag newtag = new CustomTag();

                newtag.title = textBox1.Text;
                textBox1.Clear();
                newtag.BackColor = bgcolor;

                newtag.ForeColor = bgcolor.GetBrightness() > 0.6 ? Color.Black : Color.White;

                newtag.priority = prioritySlider.Value;


                flowLayoutPanel1.Controls.Add(newtag);

                currentColorPanel.BackColor = Color.White;
                panel2.Visible = false;


            }

            private void declineButton_Click(object sender, EventArgs e)
            {
                panel2.Visible = false;
                bgcolor = Color.Transparent;
                textBox1.Clear();
            }

            private void label3_Click(object sender, EventArgs e)
            {
                ColorDialog cd = new ColorDialog();

                cd.AllowFullOpen = false;

                cd.ShowDialog();

                bgcolor = cd.Color;
                currentColorPanel.BackColor = bgcolor;

            }*/
    }

}