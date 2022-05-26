﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD2022_2
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public static String data;
        private String connectionString = "Data source=.\\rad2022_4.db;Version=3";
        SQLiteConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);

            conn.Open();
            String name = textBox3.Text;
            String email = textBox1.Text;
            String password = textBox2.Text;
            String selectSQL = "Select * from User where " +
            "email=@email and password=@password";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                conn.Close();
                this.Hide();
                if (name != "" || name != null)
                {
                    data = textBox1.Text;
                } else
                {
                    data = textBox2.Text;
                }

                Form3 f3 = new Form3(textBox1.Text);
                f3.Show();
            } else {
                conn.Close();
                Application.Exit();
            }
         }
                    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox2.MaxLength = 14;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            Console.WriteLine("This is C#");

            conn.Open();
            String name = textBox1.Text;
            String email = textBox3.Text;
            String password = textBox2.Text;
            String insertSQL = "Insert into User(name,email,password) " +
            "values(@name,@email,@password)";
            SQLiteCommand cmd = new SQLiteCommand(insertSQL, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
                MessageBox.Show(count.ToString() + " row affected");
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);

        }
    }
}
