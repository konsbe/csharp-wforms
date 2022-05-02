using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD2022_2
{
    public partial class Form3 : Form
    {
        public static String data;
        public Form3(String k)
        {
            InitializeComponent();
            data = k;
            usernameToolStripMenuItem.Text = "Welcome, "+k;
            pictureBox2.ImageLocation = @"images\download.jpg";
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(data);
            f1.Show();

        }

   

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.youtube.com/watch?v=Dqhy54VV4LY&ab_channel=alexkord1");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data = usernameToolStripMenuItem.Text;
            Form3 f3 = new Form3(usernameToolStripMenuItem.Text);
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
            else
            {
                System.Diagnostics.Process.Start("google", "https://www.google.com");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
                    }
    }
}
