﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Фбрк
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-6LQVGLT\SQLEXPRESS;Initial Catalog=Фабрика;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Пользователь where Логин = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста введите логин или пароль");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Close();
           
        }
    }
}
