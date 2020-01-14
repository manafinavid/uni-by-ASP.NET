using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace uni.student.forms
{
    public partial class ADD : Form
    {
        int Type;
        byte[] userImage=null;
        public ADD(int type)
        {
            InitializeComponent();
            Type = type;
        }
        public int result;

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (name.Text == "")
            {
                MessageBox.Show("Name field is empty");
                i++;
            }
            if (lstname.Text == "")
            {
                MessageBox.Show("Last Name field is empty");
                i++;
            }
            if (username.Text == "")
            {
                MessageBox.Show("Username field is empty");
                i++;
            }
            else { 
            SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand sql1 = new SqlCommand("select username from Person where username='" + username.Text + "'", sql);
            sql.Open();
            SqlDataReader sql2 = sql1.ExecuteReader(CommandBehavior.CloseConnection);
            if (sql2.Read() == true)
            {
                MessageBox.Show("The username already exists,Please use a different username.");
                    return;
            }
             }
            if (pass.Text == "")
            {
                MessageBox.Show("Password field is empty");
                i++;
            }
            if (repass.Text == "")
            {
                MessageBox.Show("Confirm Password field is empty");
                i++;
            }
            if (Q.Text == "")
            {
                MessageBox.Show("Question field is empty");
                i++;
            }
            if (A.Text == "")
            {
                MessageBox.Show("Answer field is empty");
                i++;
            }
            if (pass.Text!= repass.Text)
            {
                MessageBox.Show("Password and password confirmation are not the same");
                i++;
            }
            if (Email.Text == "")
            {
                MessageBox.Show("Email field is empty");
                i++;
            }
            if (i != 0)
                return;
            SqlConnection connection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("insert into person (username,Pass,nam,lastname,email,phone,Q,A,image,type) VALUES(@u,@p,@n,@l,@e,@ph,@q,@a,@i,@t)",connection);
            command.Parameters.Add("@u", SqlDbType.NVarChar).Value = username.Text;
            command.Parameters.Add("@p", SqlDbType.NVarChar).Value = pass.Text;
            command.Parameters.Add("@n", SqlDbType.NVarChar).Value = name.Text;
            command.Parameters.Add("@l", SqlDbType.NVarChar).Value = lstname.Text;
            command.Parameters.Add("@e", SqlDbType.NVarChar).Value = Email.Text;
            command.Parameters.Add("@ph", SqlDbType.NVarChar).Value = textBox1.Text;
            command.Parameters.Add("@q", SqlDbType.NVarChar).Value = Q.Text;
            command.Parameters.Add("@a", SqlDbType.NVarChar).Value = A.Text;
            command.Parameters.Add("@i", SqlDbType.Image).Value = userImage;
            char TYPE=new char();
            switch (Type)
            {
                case 1:
                    TYPE = 'a';
                    break;
                case 2:
                    TYPE = 't';
                    break;
                case 3:
                    TYPE = 's';
                    break;
            }
            command.Parameters.Add("@t", SqlDbType.NVarChar).Value = TYPE;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            result = 1;
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
                e.Handled = !char.IsDigit(e.KeyChar) ? true : false;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bits= new Bitmap(open.FileName);
                ImageConverter converter = new ImageConverter();
                userImage = converter.ConvertTo(bits, typeof(byte[])) as byte[];
            }
        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
