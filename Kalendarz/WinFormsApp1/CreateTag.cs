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
    public partial class CreateTag : UserControl
    {
        public string title
        {
            get => label1.Text;
            set
            {
                this.label1.Text = value;
                this.Invalidate();
            }
        }

        public int priority
        {
            get =>priority;

            set
            {
               this.priority = value;
               this.Invalidate();
            }
        }


        public CreateTag()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.Dispose();

        }
    }
}
