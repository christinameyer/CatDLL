using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RandomCatPictures1;

namespace RandomCatPictures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string caturl;
            GetCat cat = new GetCat();
            caturl = cat.GetCatPic();

            OpenFileDialog dlg = new OpenFileDialog();

            pictureBox1.ImageLocation = caturl;

            label1.Text = cat.CreateLabel(caturl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caturl;
            GetCat cat = new GetCat();
            caturl = cat.GetCatPic();
          
            OpenFileDialog dlg = new OpenFileDialog();

            pictureBox1.ImageLocation = caturl;

            label1.Text = cat.CreateLabel(caturl);

        }

    }
}
