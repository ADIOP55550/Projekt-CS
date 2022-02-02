namespace Kalendarz;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

public class CustomCalendar : MonthCalendar
{
    // Fields
    // -> appearance


    private Color textColor = Color.Black;


    public Color TextColor
    {
        get => textColor;
        set => textColor = value;
    }

    public CustomCalendar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
        this.MinimumSize = new Size(0, 35);
        this.Font = new Font(this.Font.Name, 10F);
    }


    protected override void OnDateSelected(DateRangeEventArgs drevent)
    {
        Console.WriteLine(drevent);

        // base.OnDateSelected(drevent);
    }
}