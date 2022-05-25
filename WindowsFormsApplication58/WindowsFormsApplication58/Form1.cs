using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication58
{
    public partial class Form1 : Form
    {
        public static String data, level;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level = "1";
            this.Hide();
            data = textBox1.Text;
            Form2 f2 = new Form2(textBox1.Text,level);
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            level = "2";
            this.Hide();
            data = textBox1.Text;
            Form2 f2 = new Form2(textBox1.Text, level);
            f2.Show();

        }
    }
}
