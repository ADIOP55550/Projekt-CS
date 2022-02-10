namespace Kalendarz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.copyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAppendButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteOverwriteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.kapibaraLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentDayLabel = new System.Windows.Forms.Label();
            this.CurrMonthPanel = new System.Windows.Forms.Panel();
            this.customCalendar1 = new Kalendarz.CustomCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.PrevMonthPanel = new System.Windows.Forms.Panel();
            this.PrevMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.NextMonthPanel = new System.Windows.Forms.Panel();
            this.NextMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.EditorPanel = new System.Windows.Forms.Panel();
            this.editorSplit = new System.Windows.Forms.SplitContainer();
            this.editorTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.highlightcheckbox = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.prioritySlider = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.currentColorPanel = new System.Windows.Forms.Panel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.declineButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.OpenMarkdownFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveMarkdownFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CurrMonthPanel.SuspendLayout();
            this.PrevMonthPanel.SuspendLayout();
            this.NextMonthPanel.SuspendLayout();
            this.EditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorSplit)).BeginInit();
            this.editorSplit.Panel1.SuspendLayout();
            this.editorSplit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prioritySlider)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ToolStrip);
            this.splitContainer1.Panel1.Controls.Add(this.LogoPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1532, 839);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // ToolStrip
            // 
            this.ToolStrip.AllowItemReorder = true;
            this.ToolStrip.BackgroundImage = global::Kalendarz.Properties.Resources.pustyPiksel;
            this.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolStrip.CanOverflow = false;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(179, 0);
            this.ToolStrip.MaximumSize = new System.Drawing.Size(0, 40);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip.Size = new System.Drawing.Size(1353, 40);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripButton4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton4.Size = new System.Drawing.Size(113, 37);
            this.toolStripButton4.Text = "Skocz do &dzisiaj";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveFileButton});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(103, 37);
            this.toolStripDropDownButton1.Text = "&Zapisz / wczytaj";
            // 
            // openFileButton
            // 
            this.openFileButton.Image = global::Kalendarz.Properties.Resources.open;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.ShortcutKeyDisplayString = "";
            this.openFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileButton.Size = new System.Drawing.Size(209, 22);
            this.openFileButton.Text = "&Otwórz z pliku";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Image = global::Kalendarz.Properties.Resources.save;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.saveFileButton.Size = new System.Drawing.Size(209, 22);
            this.saveFileButton.Text = "&Eksportuj do pliku";
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyButton,
            this.pasteAppendButton,
            this.pasteOverwriteButton});
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(92, 37);
            this.toolStripButton1.Text = "Kopiuj / wklej";
            // 
            // copyButton
            // 
            this.copyButton.Name = "copyButton";
            this.copyButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.copyButton.Size = new System.Drawing.Size(293, 22);
            this.copyButton.Text = "&Kopiuj notatkę";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteAppendButton
            // 
            this.pasteAppendButton.Name = "pasteAppendButton";
            this.pasteAppendButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.pasteAppendButton.Size = new System.Drawing.Size(293, 22);
            this.pasteAppendButton.Text = "&Wklej notatkę (dołącz)";
            this.pasteAppendButton.Click += new System.EventHandler(this.pasteAppendButton_Click);
            // 
            // pasteOverwriteButton
            // 
            this.pasteOverwriteButton.Name = "pasteOverwriteButton";
            this.pasteOverwriteButton.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.pasteOverwriteButton.Size = new System.Drawing.Size(293, 22);
            this.pasteOverwriteButton.Text = "Wklej notatkę (&nadpisz)";
            this.pasteOverwriteButton.Click += new System.EventHandler(this.pasteOverwriteButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.White;
            this.LogoPanel.BackgroundImage = global::Kalendarz.Properties.Resources.kapibara;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPanel.Controls.Add(this.kapibaraLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(179, 100);
            this.LogoPanel.TabIndex = 0;
            // 
            // kapibaraLabel
            // 
            this.kapibaraLabel.BackColor = System.Drawing.Color.Transparent;
            this.kapibaraLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kapibaraLabel.ForeColor = System.Drawing.Color.Red;
            this.kapibaraLabel.Location = new System.Drawing.Point(79, 41);
            this.kapibaraLabel.Name = "kapibaraLabel";
            this.kapibaraLabel.Size = new System.Drawing.Size(26, 29);
            this.kapibaraLabel.TabIndex = 0;
            this.kapibaraLabel.Text = ":)";
            this.kapibaraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kapibaraLabel.Click += new System.EventHandler(this.kapibaraLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrMonthPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrevMonthPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NextMonthPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EditorPanel, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1532, 735);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.currentDayLabel);
            this.panel1.Location = new System.Drawing.Point(803, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 94);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Kalendarz.Properties.Resources.icons8_plus___24;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(649, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 34);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 51);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // currentDayLabel
            // 
            this.currentDayLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentDayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentDayLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentDayLabel.Location = new System.Drawing.Point(0, 0);
            this.currentDayLabel.Name = "currentDayLabel";
            this.currentDayLabel.Size = new System.Drawing.Size(726, 94);
            this.currentDayLabel.TabIndex = 8;
            this.currentDayLabel.Text = "Dzien";
            this.currentDayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrMonthPanel
            // 
            this.CurrMonthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.SetColumnSpan(this.CurrMonthPanel, 2);
            this.CurrMonthPanel.Controls.Add(this.customCalendar1);
            this.CurrMonthPanel.Controls.Add(this.label2);
            this.CurrMonthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrMonthPanel.Location = new System.Drawing.Point(3, 3);
            this.CurrMonthPanel.Name = "CurrMonthPanel";
            this.tableLayoutPanel1.SetRowSpan(this.CurrMonthPanel, 2);
            this.CurrMonthPanel.Size = new System.Drawing.Size(794, 494);
            this.CurrMonthPanel.TabIndex = 0;
            this.CurrMonthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CurrMonthPanel_Paint);
            // 
            // customCalendar1
            // 
            this.customCalendar1.BackColor = System.Drawing.Color.White;
            this.customCalendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customCalendar1.CurrMonth = 2;
            this.customCalendar1.CurrYear = 2022;
            this.customCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customCalendar1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.customCalendar1.Location = new System.Drawing.Point(0, 0);
            this.customCalendar1.Name = "customCalendar1";
            this.customCalendar1.Size = new System.Drawing.Size(794, 494);
            this.customCalendar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tu będzie customowa kontrolka Custom Calendar";
            // 
            // PrevMonthPanel
            // 
            this.PrevMonthPanel.BackColor = System.Drawing.Color.White;
            this.PrevMonthPanel.Controls.Add(this.PrevMonthCalendar);
            this.PrevMonthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrevMonthPanel.Location = new System.Drawing.Point(3, 503);
            this.PrevMonthPanel.Name = "PrevMonthPanel";
            this.PrevMonthPanel.Size = new System.Drawing.Size(394, 209);
            this.PrevMonthPanel.TabIndex = 1;
            // 
            // PrevMonthCalendar
            // 
            this.PrevMonthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevMonthCalendar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrevMonthCalendar.Location = new System.Drawing.Point(63, 9);
            this.PrevMonthCalendar.MaxDate = new System.DateTime(2022, 2, 28, 0, 0, 0, 0);
            this.PrevMonthCalendar.MaxSelectionCount = 1;
            this.PrevMonthCalendar.MinDate = new System.DateTime(2022, 2, 1, 22, 32, 20, 0);
            this.PrevMonthCalendar.Name = "PrevMonthCalendar";
            this.PrevMonthCalendar.ShowToday = false;
            this.PrevMonthCalendar.ShowWeekNumbers = true;
            this.PrevMonthCalendar.TabIndex = 0;
            this.PrevMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.PrevMonthCalendar_DateSelected);
            // 
            // NextMonthPanel
            // 
            this.NextMonthPanel.BackColor = System.Drawing.Color.White;
            this.NextMonthPanel.Controls.Add(this.NextMonthCalendar);
            this.NextMonthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextMonthPanel.Location = new System.Drawing.Point(403, 503);
            this.NextMonthPanel.Name = "NextMonthPanel";
            this.NextMonthPanel.Size = new System.Drawing.Size(394, 209);
            this.NextMonthPanel.TabIndex = 2;
            // 
            // NextMonthCalendar
            // 
            this.NextMonthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextMonthCalendar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextMonthCalendar.Location = new System.Drawing.Point(61, 9);
            this.NextMonthCalendar.MaxDate = new System.DateTime(2022, 2, 28, 0, 0, 0, 0);
            this.NextMonthCalendar.MaxSelectionCount = 1;
            this.NextMonthCalendar.MinDate = new System.DateTime(2022, 2, 1, 22, 32, 20, 0);
            this.NextMonthCalendar.Name = "NextMonthCalendar";
            this.NextMonthCalendar.ShowToday = false;
            this.NextMonthCalendar.ShowWeekNumbers = true;
            this.NextMonthCalendar.TabIndex = 0;
            this.NextMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.NextMonthCalendar_DateSelected);
            // 
            // EditorPanel
            // 
            this.EditorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditorPanel.BackColor = System.Drawing.Color.White;
            this.EditorPanel.Controls.Add(this.editorSplit);
            this.EditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorPanel.Location = new System.Drawing.Point(803, 103);
            this.EditorPanel.Name = "EditorPanel";
            this.tableLayoutPanel1.SetRowSpan(this.EditorPanel, 2);
            this.EditorPanel.Size = new System.Drawing.Size(726, 609);
            this.EditorPanel.TabIndex = 3;
            // 
            // editorSplit
            // 
            this.editorSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorSplit.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.editorSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorSplit.Location = new System.Drawing.Point(0, 0);
            this.editorSplit.Name = "editorSplit";
            this.editorSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // editorSplit.Panel1
            // 
            this.editorSplit.Panel1.Controls.Add(this.editorTextBox);
            // 
            // editorSplit.Panel2
            // 
            this.editorSplit.Panel2.BackColor = System.Drawing.Color.White;
            this.editorSplit.Size = new System.Drawing.Size(726, 609);
            this.editorSplit.SplitterDistance = 302;
            this.editorSplit.TabIndex = 0;
            // 
            // editorTextBox
            // 
            this.editorTextBox.BackColor = System.Drawing.Color.Beige;
            this.editorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editorTextBox.Location = new System.Drawing.Point(0, 0);
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.Size = new System.Drawing.Size(724, 300);
            this.editorTextBox.TabIndex = 0;
            this.editorTextBox.Text = "";
            this.editorTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.highlightcheckbox);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.declineButton);
            this.panel2.Controls.Add(this.confirmButton);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(1275, 207);
            this.panel2.MaximumSize = new System.Drawing.Size(252, 310);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(252, 310);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(20, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nazwa taga";
            this.textBox1.Size = new System.Drawing.Size(210, 27);
            this.textBox1.TabIndex = 1;
            // 
            // highlightcheckbox
            // 
            this.highlightcheckbox.BackColor = System.Drawing.Color.Transparent;
            this.highlightcheckbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highlightcheckbox.Location = new System.Drawing.Point(23, 194);
            this.highlightcheckbox.Name = "highlightcheckbox";
            this.highlightcheckbox.Padding = new System.Windows.Forms.Padding(6);
            this.highlightcheckbox.Size = new System.Drawing.Size(207, 36);
            this.highlightcheckbox.TabIndex = 4;
            this.highlightcheckbox.Text = "Użyj jako tło";
            this.highlightcheckbox.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.priorityLabel);
            this.panel5.Controls.Add(this.prioritySlider);
            this.panel5.Location = new System.Drawing.Point(20, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 66);
            this.panel5.TabIndex = 12;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priorityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.priorityLabel.Location = new System.Drawing.Point(0, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(210, 15);
            this.priorityLabel.TabIndex = 8;
            this.priorityLabel.Text = "Priorytet";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prioritySlider
            // 
            this.prioritySlider.BackColor = System.Drawing.Color.GhostWhite;
            this.prioritySlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prioritySlider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prioritySlider.LargeChange = 1;
            this.prioritySlider.Location = new System.Drawing.Point(0, 21);
            this.prioritySlider.Name = "prioritySlider";
            this.prioritySlider.Size = new System.Drawing.Size(210, 45);
            this.prioritySlider.TabIndex = 3;
            this.prioritySlider.Value = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.GhostWhite;
            this.panel4.Controls.Add(this.currentColorPanel);
            this.panel4.Controls.Add(this.ColorLabel);
            this.panel4.Location = new System.Drawing.Point(20, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 30);
            this.panel4.TabIndex = 11;
            // 
            // currentColorPanel
            // 
            this.currentColorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentColorPanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.currentColorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.currentColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentColorPanel.Location = new System.Drawing.Point(180, 5);
            this.currentColorPanel.Margin = new System.Windows.Forms.Padding(5);
            this.currentColorPanel.Name = "currentColorPanel";
            this.currentColorPanel.Size = new System.Drawing.Size(25, 20);
            this.currentColorPanel.TabIndex = 2;
            this.currentColorPanel.TabStop = true;
            this.currentColorPanel.Click += new System.EventHandler(this.ColorLabel_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColorLabel.Location = new System.Drawing.Point(0, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Padding = new System.Windows.Forms.Padding(4);
            this.ColorLabel.Size = new System.Drawing.Size(210, 30);
            this.ColorLabel.TabIndex = 8;
            this.ColorLabel.Text = "Kolor";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorLabel.Click += new System.EventHandler(this.ColorLabel_Click);
            // 
            // declineButton
            // 
            this.declineButton.BackColor = System.Drawing.Color.MistyRose;
            this.declineButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.declineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declineButton.Location = new System.Drawing.Point(149, 246);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(81, 32);
            this.declineButton.TabIndex = 6;
            this.declineButton.Text = "Anuluj";
            this.declineButton.UseVisualStyleBackColor = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.LightCyan;
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(23, 246);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(82, 32);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Zapisz";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // OpenMarkdownFileDialog
            // 
            this.OpenMarkdownFileDialog.FileName = "note.md";
            this.OpenMarkdownFileDialog.Filter = "Markdown files (*.md)|*.md|All files (*.*)|*.*";
            this.OpenMarkdownFileDialog.Title = "Otwórz notatkę";
            // 
            // SaveMarkdownFileDialog
            // 
            this.SaveMarkdownFileDialog.DefaultExt = "md";
            this.SaveMarkdownFileDialog.FileName = "notatka.md";
            this.SaveMarkdownFileDialog.Filter = "Markdown files (*.md)|*.md|All files (*.*)|*.*";
            this.SaveMarkdownFileDialog.Title = "Eksportuj notatkę...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1532, 839);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1200, 820);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kapibara";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CurrMonthPanel.ResumeLayout(false);
            this.CurrMonthPanel.PerformLayout();
            this.PrevMonthPanel.ResumeLayout(false);
            this.NextMonthPanel.ResumeLayout(false);
            this.EditorPanel.ResumeLayout(false);
            this.editorSplit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorSplit)).EndInit();
            this.editorSplit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prioritySlider)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip ToolStrip;
        private ToolStripButton toolStripButton4;
        private Panel LogoPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel CurrMonthPanel;
        private CustomCalendar customCalendar1;
        private Label label2;
        private Panel PrevMonthPanel;
        private MonthCalendar PrevMonthCalendar;
        private Panel NextMonthPanel;
        private MonthCalendar NextMonthCalendar;
        private Panel EditorPanel;
        private SplitContainer editorSplit;
        private RichTextBox editorTextBox;
        private Panel panel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel5;
        private Label priorityLabel;
        private TrackBar prioritySlider;
        private Panel panel4;
        private Label ColorLabel;
        private Panel currentColorPanel;
        private TextBox textBox1;
        private Button declineButton;
        private Button confirmButton;
        private Label kapibaraLabel;
        private Label currentDayLabel;
        private CheckBox highlightcheckbox;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem openFileButton;
        private ToolStripMenuItem saveFileButton;
        private OpenFileDialog OpenMarkdownFileDialog;
        private SaveFileDialog SaveMarkdownFileDialog;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem copyButton;
        private ToolStripMenuItem pasteAppendButton;
        private ToolStripMenuItem pasteOverwriteButton;
    }
}
