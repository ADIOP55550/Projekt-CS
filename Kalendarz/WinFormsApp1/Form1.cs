using Markdig;


namespace Kalendarz
{
    public partial class Form1 : Form
    {
        private readonly WebBrowser _webBrowser;
        private readonly string _styles = Properties.Resources.MarkdownGithubThemeLight;
        private readonly string _stylesDark = Properties.Resources.MarkdownGithubThemeDark;
        private bool _useDarkTheme;

        private Color bgcolor = Color.White;

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

        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            currentColorPanel.BackColor = Color.White;
            var now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);

            this._webBrowser = new WebBrowser();
            _webBrowser.Dock = DockStyle.Fill;

            editorSplit.Panel2.Controls.Add(_webBrowser);


            customCalendar1.FirstDayOfWeek = DayOfWeek.Sunday;
            // customCalendar1.init();

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

            TranspileMarkdown("");
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
            TranspileMarkdown(((RichTextBox) sender).Text);
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

        private void ToolStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        }
    }
}