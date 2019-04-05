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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void studentID_Click(object sender, EventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username and Password is correct for sutdent");
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();        //hides the current form
            student f2 = new student(); //create form2 ojbect
            f2.ShowDialog(); //opens form2
        }

        private void createNew_Enter(object sender, EventArgs e)
        {

        }
    }
}
