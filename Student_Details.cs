﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Student
{
    public partial class Student_Details : Form
    {
        public Student_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Student std = new Student())
            {
                std.lbl = "Add Information Here!";
                std.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Student std = new Student())
            {
                std.lbl = "Update Information Here!";
                std.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
