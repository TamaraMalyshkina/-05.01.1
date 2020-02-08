﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String pass = textBox2.Text;

            Class1 class1 = new Class1();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM 'users' WHERE 'login' = @L AND 'pass' = @P", class1.get());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Молодец, хорошая память!");
            else
                MessageBox.Show("Ты чё-то попутал. Давай ещё. Напрягай свою единственную извилину!");
        }
    }
}
