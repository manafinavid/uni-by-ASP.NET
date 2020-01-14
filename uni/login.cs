// maked by navid
// manafinavid@yahoo.com
// https://github.com/manafinavid
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = default(SqlConnection);
            myConnection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand myCommand = default(SqlCommand);
            myCommand = new SqlCommand(string.Format("SELECT Id,type FROM Person WHERE Username = '{0}' AND Pass= '{1}' ;",Username.Text,Password.Text), myConnection);
            myCommand.Connection.Open();
            SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            
            if (myReader.Read() == true)
            {
                MessageBox.Show("You have logged in successfully " + Username.Text);
                this.Hide();
                Form i = new students(int.Parse(myReader[0].ToString()), myReader[1].ToString()[0]);
                myConnection.Close();
                i.Show();
                myConnection.Close();
            }  
        }

        
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget_pass lo = new forget_pass();
            lo.ParenFormt = this;
            this.Hide();
            lo.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
