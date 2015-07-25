using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.trackBar3_ValueChanged(this, null);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar3.Value,trackBar1.Value,trackBar2.Value);
        }
    }
}
