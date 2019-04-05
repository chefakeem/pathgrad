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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void viewMore_Click(object sender, EventArgs e)
        {
            this.Hide();        //hides the current form
            courseTrack f2 = new courseTrack(); //create form2 ojbect
            f2.ShowDialog(); //opens form2
        }

        private void currentGPA_Click(object sender, EventArgs e)
        {

        }
    }
}
