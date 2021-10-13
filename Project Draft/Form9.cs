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
    public partial class frm9 : Form
    {
        public frm9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm10 fr10 = new frm10();
            fr10.ShowDialog();
        }

        private void frm9_Load(object sender, EventArgs e)
        {

        }
    }
}
