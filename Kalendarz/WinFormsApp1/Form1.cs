using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
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
        private readonly Action _saveCallbackDebounced;
        private DateTime? _selectedDate;
        private CustomTag? editedTag;
        private Tag? editedTagPreviousState;

        private readonly Image[] _capybaras =
        {
            Properties.Resources.kapibara1,
            Properties.Resources.kapibara2,
            Properties.Resources.kapibara3,
            Properties.Resources.kapibara4,
            Properties.Resources.kapibara5,
            Properties.Resources.kapibara6,
            Properties.Resources.kapibara7,
            Properties.Resources.kapibara8,
            Properties.Resources.kapibara9,
            Properties.Resources.kapibara10,
            Properties.Resources.kapibara11,
            Properties.Resources.kapibara12,
            Properties.Resources.kapibara13,
            Properties.Resources.kapibara14,
            Properties.Resources.kapibara15,
            Properties.Resources.kapibara16,
            Properties.Resources.kapibara17,
            Properties.Resources.kapibara18,
            Properties.Resources.kapibara19,
            Properties.Resources.kapibara20,
            Properties.Resources.kapibara21,
            Properties.Resources.kapibara22,
            Properties.Resources.kapibara23
        };


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


        private void SaveNote(DateTime? day)
        {
            // save to Db

            if (day == null)
                return;

            Invoke(() =>
            {
                var entry = DaysService.GetInstance().GetDayEntry((DateTime) day);
                entry.Content = editorTextBox.Text;
                entry.Tags = new List<Tag>();

                foreach (CustomTag ct in flowLayoutPanel1.Controls) entry.Tags.Add(ct.Tag);

                DaysService.GetInstance().SaveDayEntry(entry);

                customCalendar1.ReloadDay(entry.Date);
            });
        }

        public void SaveCurrentNote()
        {
            this.SaveNote(this._selectedDate);
        }

        public Form1()
        {
            InitializeComponent();

            panel2.Visible = false;
            currentColorPanel.BackColor = Color.White;
            var now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);

            _saveCallbackDebounced = Util.Debounce(this.SaveCurrentNote, 1000);

            this._webBrowser = new WebBrowser();
            _webBrowser.Dock = DockStyle.Fill;

            editorSplit.Panel2.Controls.Add(_webBrowser);

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

            flowLayoutPanel1.Controls.Clear();

            if (e.Next != null)
            {
                LoadNote((DateTime) e.Next);
                currentDayLabel.Text = e.Next.Value.ToLongDateString();
            }
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

        private void LoadNote(DateTime day)
        {
            var entry = DaysService.GetInstance().GetDayEntry(day);
            editorTextBox.Text = entry.Content;

            flowLayoutPanel1.Controls.Clear();
            var customTags = entry.Tags.Select(CustomTag.FromTag).ToArray();
            foreach (var customTag in customTags)
            {
                customTag.OnDeleted += (sender, args) => SaveCurrentNote();
                customTag.OnEditRequest += OnTagEdit;
            }

            flowLayoutPanel1.Controls.AddRange(customTags);


            TranspileMarkdown(editorTextBox.Text);
        }

        private void OnCustomCalendarMonthChanged(object calendar, DateTime time)
        {
            PrevMonthCalendar.MaxDate = DateTime.MaxValue;
            PrevMonthCalendar.MinDate = time.AddMonths(-1);
            PrevMonthCalendar.MaxDate = time.AddDays(-1);

            NextMonthCalendar.MinDate = DateTime.UnixEpoch;
            NextMonthCalendar.MaxDate = time.AddMonths(2).AddDays(-1);
            NextMonthCalendar.MinDate = time.AddMonths(1);


            PrevMonthCalendar.BoldedDates = DaysService.GetInstance()
                .GetHighlightInfosForMonth(time.AddMonths(-1).Year, time.AddMonths(-1).Month)
                .Where(pair =>
                    pair.Value.IndicatorBorderColor != null
                    && (Color) pair.Value.IndicatorBorderColor != Color.Transparent
                    ||
                    pair.Value.IndicatorColor != null
                    && (Color) pair.Value.IndicatorColor != Color.Transparent
                    ||
                    pair.Value.HighlightColor != null
                    && (Color) pair.Value.HighlightColor != Color.Transparent
                ).Select(pair => pair.Key).ToArray();

            NextMonthCalendar.BoldedDates = DaysService.GetInstance()
                .GetHighlightInfosForMonth(time.AddMonths(1).Year, time.AddMonths(1).Month)
                .Where(pair =>
                    pair.Value.IndicatorBorderColor != null
                    && (Color) pair.Value.IndicatorBorderColor != Color.Transparent
                    ||
                    pair.Value.IndicatorColor != null
                    && (Color) pair.Value.IndicatorColor != Color.Transparent
                    ||
                    pair.Value.HighlightColor != null
                    && (Color) pair.Value.HighlightColor != Color.Transparent
                ).Select(pair => pair.Key).ToArray();
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


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this._saveCallbackDebounced();
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


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.AutoScroll = true;
            VerticalScroll.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            highlightcheckbox.Checked = false;
            textBox1.Focus();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Nie podano nazwy taga");
                return;
            }

            if (editedTag != null)
            {
                // edit

                editedTag.Title = textBox1.Text;
                editedTag.Highlight = highlightcheckbox.Checked;
                editedTag.Priority = prioritySlider.Value;
                editedTag.BackColor = currentColorPanel.BackColor;

                editedTag = null;
                editedTagPreviousState = null;

                textBox1.Clear();
                currentColorPanel.BackColor = Color.White;
                prioritySlider.Value = 0;
                panel2.Visible = false;

                SaveCurrentNote();

                return;
            }


            CustomTag newtag = new CustomTag();

            newtag.OnDeleted += (sender, args) => SaveCurrentNote();
            newtag.OnEditRequest += this.OnTagEdit;

            newtag.Title = textBox1.Text.Trim();
            newtag.BackColor = currentColorPanel.BackColor;
            newtag.ForeColor = currentColorPanel.BackColor.GetBrightness() > 0.4 ? Color.Black : Color.White;
            newtag.Priority = prioritySlider.Value;
            if (highlightcheckbox.Checked) newtag.Highlight = true;

            flowLayoutPanel1.Controls.Add(newtag);

            textBox1.Clear();
            currentColorPanel.BackColor = Color.White;
            prioritySlider.Value = 0;
            panel2.Visible = false;

            SaveCurrentNote();
        }

        private void OnTagEdit(object? sender, EventArgs e)
        {
            var editedTag = ((CustomTag) sender).Tag;

            this.editedTagPreviousState = (Tag) editedTag.Clone();
            this.editedTag = (CustomTag) sender;

            panel2.Visible = true;
            highlightcheckbox.Checked = editedTag.Highlight;
            textBox1.Text = editedTag.Name;
            prioritySlider.Value = editedTag.Priority;
            currentColorPanel.BackColor = ColorTranslator.FromHtml(editedTag.Color);
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            if (editedTag != null)
            {
                // restore state

                editedTag.Title = editedTagPreviousState!.Name;
                editedTag.Highlight = editedTagPreviousState.Highlight;
                editedTag.Priority = editedTagPreviousState.Priority;
                editedTag.BackColor = ColorTranslator.FromHtml(editedTagPreviousState.Color);

                editedTag = null;
                editedTagPreviousState = null;
            }

            panel2.Visible = false;
            currentColorPanel.BackColor = Color.Transparent;
            textBox1.Clear();
            prioritySlider.Value = 0;
        }

        private void ColorLabel_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.Color = currentColorPanel.BackColor;

            cd.AllowFullOpen = true;
            cd.AnyColor = true;
            cd.FullOpen = true;

            cd.ShowDialog();

            currentColorPanel.BackColor = cd.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kapibaraLabel.Text = DateTime.Today.Day.ToString();
            Util.setTimeout(() => { Invoke(() => { customCalendar1.SelectDay(DateTime.Today); }); }, 1);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var result = OpenMarkdownFileDialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            var fileContent = File.ReadAllText(OpenMarkdownFileDialog.FileName);

            editorTextBox.Text = fileContent;
            TranspileMarkdown(fileContent);
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            var result = SaveMarkdownFileDialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            File.WriteAllText(SaveMarkdownFileDialog.FileName, editorTextBox.Text);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(editorTextBox.Text);
        }

        private void pasteAppendButton_Click(object sender, EventArgs e)
        {
            editorTextBox.Text += Clipboard.GetText();
            TranspileMarkdown(editorTextBox.Text);
        }

        private void pasteOverwriteButton_Click(object sender, EventArgs e)
        {
            editorTextBox.Text = Clipboard.GetText();
            TranspileMarkdown(editorTextBox.Text);
        }

        private void kapibaraLabel_Click(object sender, EventArgs e)
        {
            var capybaraForm = new Form();

            capybaraForm.StartPosition = FormStartPosition.CenterParent;
            capybaraForm.BackColor = Color.White;
            capybaraForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            capybaraForm.Text = "Twoja kapibara";
            capybaraForm.ControlBox = true;
            Random r = new Random();
            capybaraForm.BackgroundImage = _capybaras[r.Next(_capybaras.Length)];
            capybaraForm.BackgroundImageLayout = ImageLayout.Zoom;

            capybaraForm.ShowDialog();
        }
    }
}