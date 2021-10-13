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
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm6 fr6 = new frm6();
            fr6 .ShowDialog();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void frm5_Load(object sender, EventArgs e)
        {

        }
    }
}
