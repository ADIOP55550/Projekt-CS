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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.themeSwitchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CurrMonthPanel.SuspendLayout();
            this.PrevMonthPanel.SuspendLayout();
            this.NextMonthPanel.SuspendLayout();
            this.EditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorSplit)).BeginInit();
            this.editorSplit.Panel1.SuspendLayout();
            this.editorSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(1279, 839);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 0;
            // 
            // ToolStrip
            // 
            this.ToolStrip.AllowItemReorder = true;
            this.ToolStrip.CanOverflow = false;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton1});
            this.ToolStrip.Location = new System.Drawing.Point(200, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1079, 70);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(1280, 1024);
            this.toolStripButton4.Text = "Skocz do dzisiaj";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImage = global::Kalendarz.Properties.Resources.pobrane__1_;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 67);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::Kalendarz.Properties.Resources.pobrane__1_;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 70);
            this.LogoPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miejsce na logo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.CurrMonthPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrevMonthPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NextMonthPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EditorPanel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.themeSwitchBtn, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1279, 765);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.PrevMonthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PrevMonthPanel.Controls.Add(this.PrevMonthCalendar);
            this.PrevMonthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrevMonthPanel.Location = new System.Drawing.Point(3, 503);
            this.PrevMonthPanel.Name = "PrevMonthPanel";
            this.PrevMonthPanel.Size = new System.Drawing.Size(394, 259);
            this.PrevMonthPanel.TabIndex = 1;
            // 
            // PrevMonthCalendar
            // 
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
            this.NextMonthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NextMonthPanel.Controls.Add(this.NextMonthCalendar);
            this.NextMonthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextMonthPanel.Location = new System.Drawing.Point(403, 503);
            this.NextMonthPanel.Name = "NextMonthPanel";
            this.NextMonthPanel.Size = new System.Drawing.Size(394, 259);
            this.NextMonthPanel.TabIndex = 2;
            // 
            // NextMonthCalendar
            // 
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
            this.EditorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.EditorPanel.Controls.Add(this.editorSplit);
            this.EditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorPanel.Location = new System.Drawing.Point(803, 103);
            this.EditorPanel.Name = "EditorPanel";
            this.tableLayoutPanel1.SetRowSpan(this.EditorPanel, 2);
            this.EditorPanel.Size = new System.Drawing.Size(473, 659);
            this.EditorPanel.TabIndex = 3;
            // 
            // editorSplit
            // 
            this.editorSplit.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.editorSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorSplit.Location = new System.Drawing.Point(0, 0);
            this.editorSplit.Name = "editorSplit";
            this.editorSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // editorSplit.Panel1
            // 
            this.editorSplit.Panel1.Controls.Add(this.editorTextBox);
            this.editorSplit.Size = new System.Drawing.Size(473, 659);
            this.editorSplit.SplitterDistance = 327;
            this.editorSplit.TabIndex = 0;
            // 
            // editorTextBox
            // 
            this.editorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTextBox.Location = new System.Drawing.Point(0, 0);
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.Size = new System.Drawing.Size(473, 327);
            this.editorTextBox.TabIndex = 0;
            this.editorTextBox.Text = "";
            this.editorTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // themeSwitchBtn
            // 
            this.themeSwitchBtn.Location = new System.Drawing.Point(803, 3);
            this.themeSwitchBtn.Name = "themeSwitchBtn";
            this.themeSwitchBtn.Size = new System.Drawing.Size(118, 23);
            this.themeSwitchBtn.TabIndex = 4;
            this.themeSwitchBtn.Text = "Switch theme";
            this.themeSwitchBtn.UseVisualStyleBackColor = true;
            this.themeSwitchBtn.Click += new System.EventHandler(this.themeSwitchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 839);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.Text = "Kapibara";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CurrMonthPanel.ResumeLayout(false);
            this.CurrMonthPanel.PerformLayout();
            this.PrevMonthPanel.ResumeLayout(false);
            this.NextMonthPanel.ResumeLayout(false);
            this.EditorPanel.ResumeLayout(false);
            this.editorSplit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorSplit)).EndInit();
            this.editorSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip ToolStrip;
        private ToolStripButton toolStripButton4;
        private Panel LogoPanel;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel CurrMonthPanel;
        private Panel PrevMonthPanel;
        private Panel NextMonthPanel;
        private Panel EditorPanel;
        private MonthCalendar PrevMonthCalendar;
        private MonthCalendar NextMonthCalendar;
        private Label label2;
        private CustomCalendar customCalendar1;
        private ToolStripButton toolStripButton1;
        private SplitContainer editorSplit;
        private RichTextBox editorTextBox;
        private Button themeSwitchBtn;
    }
}