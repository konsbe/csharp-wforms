﻿using System;
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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public static String data;
        public Form1(String k)
        {
            InitializeComponent();
            data = k;
            usernameToolStripMenuItem.Text = "Welcome, " + k;
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"images\maxresdefault.jpg";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("IExplore", "http://www.google.com");
            System.Diagnostics.Process.Start("IExplore", "http://www.youtube.com/watch?v=Dqhy54VV4LY&ab_channel=alexkord1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("textfiles\\unipi.txt",RichTextBoxStreamType.PlainText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
            else
            {
                    System.Diagnostics.Process.Start("google", "https://www.google.com");
            }
            //colorDialog1.ShowDialog();
            //this.BackColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath+"\\textfiles";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("BSB.wav");
            player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(data);
            f3.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

   

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}