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

        public DateTime Day { get; set; }
        public List<string> tags { get; set; } = new();
        public Color HighlightColor
        {
            get => _highlightColor;
            set
            {
                if (_highlightColor == value)
                    return;
                _highlightColor = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (_borderColor == value)
                    return;
                _borderColor = value;
                Invalidate();
            }
        }

        public Color CircleColor
        {
            get => _circleColor;
            set
            {
                if (_circleColor == value)
                    return;
                _circleColor = value;
                Invalidate();
            }
        }

        public Color CircleInnerColor
        {
            get => _circleInnerColor;
            set
            {
                if (_circleInnerColor == value)
                    return;
                _circleInnerColor = value;
                Invalidate();
            }
        }

        private bool _isLowlighted = false;

        public bool IsLowlighted
        {
            get => _isLowlighted;
            set
            {
                if (_isLowlighted == value)
                    return;
                _isLowlighted = value;

                Font = new Font(Font.Name, Font.Size, _isLowlighted ? FontStyle.Regular : FontStyle.Bold);
                Invalidate();
            }
        }


        public int CircleSize = 10;
        public Point CirclePoint = new(5, 5);
        private Color _circleInnerColor = Color.Transparent;
        private Color _circleColor = Color.Transparent;
        private Color _borderColor = Color.Transparent;
        private Color _highlightColor = Color.Transparent;


        public CalendarDay(Font font, DateTime day)
        {
            InitializeComponent();
            this.Day = day;
            SetStyle(ControlStyles.UserPaint, true);
            // this.Font = font;
            this.Font = new Font(font.Name, font.Size, _isLowlighted ? FontStyle.Regular : FontStyle.Bold);
        }

        protected Color processColor(Color c, int alpha = 70)
        {
            return c == Color.Transparent ? c : IsLowlighted ? Color.FromArgb(alpha, c) : c;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            using var indicatorBrush = new SolidBrush(processColor(this.CircleInnerColor));
            using var highlightBrush = new SolidBrush(processColor(this.HighlightColor));
            using var indicatorPen = new Pen(processColor(this.CircleColor), 2F);
            using var borderPen = new Pen(processColor(this.BorderColor), 4F);

            graphics.FillRectangle(highlightBrush, this.DisplayRectangle);
            graphics.DrawRectangle(borderPen, this.DisplayRectangle);
            var r2 = new Rectangle(CirclePoint, new Size(CircleSize, CircleSize));
            r2.Inflate(new Size(4, 4));
            graphics.FillEllipse(indicatorBrush, r2);
            graphics.DrawEllipse(indicatorPen, r2);
            graphics.DrawString(this.Text, this.Font,
                new SolidBrush(processColor(this.ForeColor)),
                new Point((int) (this.Width / 2 - this.Font.Size), (int) (this.Height / 2 - this.Font.Size)));
        }
    }
}