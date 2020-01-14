using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uni
{
    public partial class forget_pass : Form
    {
        public forget_pass()
        {
            InitializeComponent();
        }
        public Form ParenFormt { get; set; }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection connection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command = new SqlCommand("select id FROM Person where username = '" + textBox1.Text + "'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read() == true)
                {
                    int ID = (int)reader[0];
                    reader.Close();
                    connection.Close();
                    panel1.Visible = false;
                    panel2.Visible = true;
                    command.CommandText= "select Q from Person where Id=" + ID ;
                    connection.Open();
                    reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    if ( reader.Read() == true)
                    { 
                    label2.Text += reader[0].ToString();
                    goto e;
                    }
                }
                connection.Close();
            }
            MessageBox.Show("An error has occurred!!!");
        e: int i; 
            }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection connection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command = new SqlCommand("select A FROM Person where username = '" + textBox1.Text + "'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read() == true)
                {
                    panel2.Visible = false;
                    panel3.Visible = true;
                    connection.Close();
                  goto e;
                }
                connection.Close();
            }
            MessageBox.Show("An error has occurred!!!");
        e: int i;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ParenFormt.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text == textBox3.Text)
            {
                SqlConnection connection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command = new SqlCommand(string.Format("update Person set Pass={0} where username = '{1}' AND A='{2}'",textBox3.Text ,textBox1.Text, textBox2.Text), connection);
                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Your password has been changed successfully!!");
                    connection.Close();
                    this.Close();
                    ParentForm.Show();
                    goto e;
                }
                connection.Close();
            }
            MessageBox.Show("An error has occurred!!!");
        e: int i;
        }
    }
}
