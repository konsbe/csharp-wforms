using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication58
{
    public partial class Form3 : Form

    {
        public static String data;

        public Form3(String k)
        {
            InitializeComponent();
            data = k;
            usernameToolStripMenuItem.Text = "Welcome, " + k;
            richTextBox1.LoadFile("textfiles\\scoreboard.txt", RichTextBoxStreamType.PlainText);
        }
        public Form3()
        {
            InitializeComponent();
        }  
   

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("textfiles\\scoreboard.txt", RichTextBoxStreamType.PlainText);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
