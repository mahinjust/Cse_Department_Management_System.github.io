﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Test
{
    public partial class Test_Details : Form
    {
        public Test_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Add_Test ct = new Add_Test())
            {
                ct.lbl = "Add Information Here!";
                ct.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Add_Test ct = new Add_Test())
            {
                ct.lbl = "Update Information Here!";
                ct.ShowDialog();
            }
        }
    }
}
