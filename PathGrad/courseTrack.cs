using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathGrad
{
    public partial class courseTrack : Form
    {
        public courseTrack()
        {
            InitializeComponent();
        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();        //hides the current form
            student f2 = new student(); //create form2 ojbect
            f2.ShowDialog(); //opens form2
        }
    }
}
