﻿using System;
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
    public partial class frmBegin : Form
    {
          
        public frmBegin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm5 fr5 = new frm5();
            fr5.ShowDialog();
        }
    }
}
