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
    public partial class CalendarDay : UserControl
    {
        /// <summary>
        /// Selected/Deselected event sentinel type
        /// </summary>
        private static readonly object s_indicatorClicked = new();

        /// <summary>
        /// The day this object is set to, also sets displayed text
        /// </summary>
        public DateTime Day
        {
            get => _day;
            set
            {
                _day = value;
                this._label.Text = value.Day.ToString();
            }
        }

        /// <summary>
        /// Sets the color which is in the background of the label. If the color is dark, make sure to invert foreground color!
        /// </summary>
        public Color HighlightColor
        {
            get => _highlightColor;
            private set
            {
                if (_highlightColor == value)
                    return;
                _highlightColor = value;
                this._label.BackColor = value;
            }
        }

        /// <summary>
        /// Foreground color for a day that is not lowlighted
        /// </summary>
        public Color HighlightForeColor
        {
            get => _highlightForeColor;
            set
            {
                _highlightForeColor = value;
                this._label.Invalidate();
            }
        }

        /// <summary>
        /// Foreground color for lowlighted day (a day that is from other month)
        /// </summary>
        public Color LowlightForeColor
        {
            get => _lowlightForeColor;
            set
            {
                _lowlightForeColor = value;
                this._label.Invalidate();
            }
        }

        /// <summary>
        /// Border color of the day label
        /// </summary>
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (_borderColor == value)
                    return;
                _borderColor = value;
                this._borderPanel.Invalidate();
            }
        }

        /// <summary>
        /// Color of the outer indicator (border)
        /// </summary>
        public Color IndicatorColor
        {
            get => _indicatorColor;
            private set
            {
                if (_indicatorColor == value)
                    return;
                _indicatorColor = value;
                this._indicator.Invalidate();
            }
        }

        /// <summary>
        /// Color of the inner indicator (dot)
        /// </summary>
        public Color IndicatorInnerColor
        {
            get => _indicatorInnerColor;
            private set
            {
                if (_indicatorInnerColor == value)
                    return;
                _indicatorInnerColor = value;
                this._indicator.Invalidate();
            }
        }

        private bool _isLowlighted = false;

        /// <summary>
        /// Whether the day is lowlighted (e.g. it is from a different month)
        /// </summary>
        public bool IsLowlighted
        {
            get => _isLowlighted;
            set
            {
                if (_isLowlighted == value)
                    return;
                _isLowlighted = value;

                _label.Font = new Font(_label.Font.Name, _label.Font.Size,
                    _isLowlighted ? FontStyle.Regular : FontStyle.Bold);
                _label.ForeColor = _isLowlighted ? LowlightForeColor : HighlightForeColor;
            }
        }


        /// <summary>
        /// Size of the inner indicator
        /// </summary>
        public int IndicatorSize { get; } = 16;

        /// <summary>
        /// Size of the inner indicator's border
        /// </summary>
        public int IndicatorBorderThickness { get; set; } = 4;

        public Point IndicatorPosition { get; } = new(8, 8);

        /// <summary>
        /// Label border thickness
        /// </summary>
        public int BorderThickness { get; set; } = 1;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                _borderPanel.Invalidate();
            }
        }

        public HighlightInfo HighlightInfo
        {
            get => _highlightInfo;
            set
            {
                _highlightInfo = value;
                this.ApplyHighlightInfo();
            }
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler<DateTime>? IndicatorClicked
        {
            add => Events.AddHandler(s_indicatorClicked, value);
            remove => Events.RemoveHandler(s_indicatorClicked, value);
        }


        private Color _indicatorInnerColor = Color.Transparent;
        private Color _indicatorColor = Color.Transparent;
        private Color _borderColor = Color.Transparent;
        private Color _highlightColor = Color.Transparent;
        private DateTime _day;
        private readonly Label _label;
        private readonly Panel _indicator;
        private readonly Panel _borderPanel;
        private Color _highlightForeColor = Color.Black;
        private Color _lowlightForeColor = Color.LightGray;
        private HighlightInfo _highlightInfo = new HighlightInfo();
        private bool _isSelected;

        public static Color SelectedDayBorderColor { get; set; } = Color.Red;

        private void OnIndicatorPaint(object? sender, PaintEventArgs e)
        {
            if (sender != null)
            {
                // Get size of the indicator
                var clientRectangle = ((Panel) sender).ClientRectangle;
                clientRectangle.Inflate(
                    new Size(-(this.IndicatorBorderThickness / 2 + 1), -(this.IndicatorBorderThickness / 2 + 1)));
                // Draw border
                e.Graphics.DrawEllipse(new Pen(IndicatorColor, this.IndicatorBorderThickness), clientRectangle);
                // Resize rect to fit border size
                clientRectangle.Inflate(
                    new Size(-this.IndicatorBorderThickness / 2, -this.IndicatorBorderThickness / 2));
                // Draw center
                e.Graphics.FillEllipse(new SolidBrush(IndicatorInnerColor), clientRectangle);

                ((Panel) sender).Cursor =
                    IndicatorColor == Color.Transparent
                        ? Cursors.Arrow
                        : Cursors.Hand;
            }
        }

        private void OnBorderPaint(object? sender, PaintEventArgs e)
        {
            if (sender != null)
            {
                // Get size of the indicator
                var clientRectangle = ((Panel) sender).ClientRectangle;
                clientRectangle.Inflate(new Size(-BorderThickness, -BorderThickness));
                var color = _isSelected ? SelectedDayBorderColor : this.BorderColor;

                e.Graphics.DrawLines(new Pen(color, this.BorderThickness), new[]
                {
                    new PointF(clientRectangle.Left, clientRectangle.Top),
                    new PointF(clientRectangle.Right, clientRectangle.Top),
                    new PointF(clientRectangle.Right, clientRectangle.Bottom),
                    new PointF(clientRectangle.Left, clientRectangle.Bottom),
                    new PointF(clientRectangle.Left, clientRectangle.Top)
                });
            }
        }

        public CalendarDay(Font font, DateTime day)
        {
            InitializeComponent();
            // SetStyle(ControlStyles.UserPaint, true);
            // this.Font = font;

            this.Dock = DockStyle.Fill;

            var label = new Label();
            this._label = label;
            label.Font = new Font(font.Name, font.Size, _isLowlighted ? FontStyle.Regular : FontStyle.Bold);
            label.ForeColor = _isLowlighted ? LowlightForeColor : HighlightForeColor;

            label.Dock = DockStyle.Fill;
            // label.Text = day.Day.ToString();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.AutoSize = false;
            label.BackColor = Color.Transparent;
            // label.BackColor = Color.Aquamarine;
            label.Click += (sender, args) => this.OnClick(args);
            label.DoubleClick += (sender, args) => this.OnDoubleClick(args);
            label.MouseDown += (sender, args) => this.OnMouseDown(args);

            this.Day = day;

            var indicator = new Panel();
            this._indicator = indicator;
            indicator.AutoSize = false;
            indicator.Size = new Size(this.IndicatorSize, this.IndicatorSize);
            indicator.Top = this.IndicatorPosition.Y;
            indicator.Left = this.IndicatorPosition.X;
            indicator.Paint += this.OnIndicatorPaint;

            // indicator.Click += (sender, args) => this.OnClick(args);
            // indicator.DoubleClick += (sender, args) => this.OnDoubleClick(args);
            // indicator.MouseDown += (sender, args) => this.OnMouseDown(args);
            indicator.MouseDown += (sender, args) =>
            {
                if (args.Button == MouseButtons.Left)
                    ((EventHandler<DateTime>?) Events[s_indicatorClicked])?.Invoke(this, this.Day);
            };


            var borderPanel = new Panel();
            this._borderPanel = borderPanel;
            borderPanel.AutoSize = false;
            borderPanel.BackColor = Color.Transparent;
            borderPanel.Dock = DockStyle.Fill;
            borderPanel.Paint += this.OnBorderPaint;
            borderPanel.Click += (sender, args) => this.OnClick(args);
            borderPanel.DoubleClick += (sender, args) => this.OnDoubleClick(args);
            borderPanel.MouseDown += (sender, args) => this.OnMouseDown(args);

            this.Controls.Add(label);
            label.Controls.Add(indicator);
            label.Controls.Add(borderPanel);
        }

        private void ApplyHighlightInfo()
        {
            this.BorderColor = this.HighlightInfo.BorderColor ?? Color.Transparent;
            this.HighlightColor = this.HighlightInfo.HighlightColor ?? Color.Transparent;
            this.IndicatorInnerColor = this.HighlightInfo.IndicatorColor ?? Color.Transparent;
            this.IndicatorColor = this.HighlightInfo.IndicatorBorderColor ?? Color.Transparent;
        }
    }
}