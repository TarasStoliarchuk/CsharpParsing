using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twchprs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] gg =  Work.inf(textBoxx.Text);
            string[] ff = Work.photo(textBoxx.Text);
            label1.Text = gg[0];
            label2.Text = gg[1];
            label3.Text = gg[2];
            label4.Text = gg[3];
            label5.Text = gg[4];
            pictureBox1.ImageLocation = ff[0];
            pictureBox2.ImageLocation = ff[1];
            pictureBox3.ImageLocation = ff[2];
            pictureBox4.ImageLocation = ff[3];
            pictureBox5.ImageLocation = ff[4];
        }

  
    }
}
