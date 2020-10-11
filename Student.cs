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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        public string lbl;
        private void Student_Load(object sender, EventArgs e)
        {
            lblstd.Text = lbl;
            if (lblstd.Text== "Add Information Here!")
            {
                button5.Text = "Add";
            }
            else if (lblstd.Text== "Update Information Here!")
            {
                button5.Text = "Update";
            }

        }
        byte[] Filename;

        byte[] ImageToByteArray(Image img,PictureBox px)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (px!=null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result==DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(fileDialog.FileName);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                Filename = ImageToByteArray(pictureBox1.BackgroundImage,pictureBox1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
