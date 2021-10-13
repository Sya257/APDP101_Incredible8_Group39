using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Draft
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
             
          


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmBooking fr2 = new frmBooking();
            fr2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdminLogin fr7 = new frmAdminLogin();
            fr7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME TO THE ROAD TO YOUR SUCCESS");
            MessageBox.Show("Take note of the procedure for this application... After you have successfully made a booking for the learners license" +
                " ,you will be directed to the rules of the Learner's test. Thereafter, you will proceed with the test. The test is based on Code 2" +
                " which is Motor vehicles. ");

        }
    }
}
