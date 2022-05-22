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
            txt.WriteLine(data + " " + DateTime.Now+"\n");
            txt.Close();
            this.Close();

            Form1 f1 = new Form1();
            f1.Show();
        }

        private void scorersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("textfiles\\scoreboard.txt", true);
            txt.WriteLine(data + " " + DateTime.Now + "\n");
            txt.Close();
            this.Close();

            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
