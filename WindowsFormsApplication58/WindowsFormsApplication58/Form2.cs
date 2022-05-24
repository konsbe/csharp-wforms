using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication58
{
    public partial class Form2 : Form
    {
        public static String data;
        string message, score;
        Random r;
        int hitcounter, time;
        public Form2(String k)
        {
            InitializeComponent();
            data = k;
            usernameToolStripMenuItem.Text = "Welcome, " + k+" "+ DateTime.Now;

        }
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = message;
            r = new Random();
            time = 0;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("textfiles\\scoreboard.txt", true);
            txt.WriteLine(data + " " + DateTime.Now+ "score:  "+ score +"\n");
            txt.Close();
            this.Close();

            Form1 f1 = new Form1();
            f1.Show();
        }

        private void scorersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("textfiles\\scoreboard.txt", true);
            txt.WriteLine(data + " " + DateTime.Now + " score:  " + score + "\n");
            txt.Close();
            this.Close();

            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hitcounter++;
            label2.Text = hitcounter.ToString() + " hits!";
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = r.Next(0, 992);
            int y = r.Next(0, 492);
            pictureBox1.Top = y;
            pictureBox1.Left = x;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time++;
            label3.Text = time.ToString();
            if (time == 5)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                pictureBox1.Hide();
                MessageBox.Show("Game Over!");
                score = hitcounter.ToString();
            }
        }

    }
}
