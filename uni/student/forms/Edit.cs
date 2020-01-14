using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uni.student.forms
{
    public partial class Edit : Form
    {
        bool image=false;
        byte[] map;
        public Edit(char type)
        {
            InitializeComponent();
            user = type.ToString();
        }
        string user;
        List<string> a=new List<string>();
        private void Edit_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            this.Size = new System.Drawing.Size(327, 85);
            SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("select username,nam,lastname,id from Person where type='" + user+"'",sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while(reader.Read())
            {
                LIST.Items.Add(reader[1].ToString()+","+ reader[2].ToString() + " : "+ reader[0].ToString());
                string temp = reader[3].ToString();
                a.Add(temp);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("select * from Person where id=" + (a[LIST.SelectedIndex]), sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (!reader.Read())
            {
                MessageBox.Show("Error");
                this.Close();
            }
            name.Text= reader["nam"].ToString();
            lstname.Text= reader["lastname"].ToString();
            Q.Text = reader["Q"].ToString();
            A.Text= reader["A"].ToString();
            Email.Text= reader["email"].ToString();
            phone.Text = reader["phone"].ToString();
            username.Text = reader["username"].ToString();
            this.Size = new System.Drawing.Size(306, 333);
            pass.Text = "";
            pass.Enabled = false;
            checkBox1.Checked = false;
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(327, 85);
            panel2.Visible = false;
            panel1.Visible = true;
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            pass.Enabled = checkBox1.Checked;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string Code = "update Person set username=@u , nam=@n , lastname=@ln , email=@e , phone=@ph , Q=@q , A=@a";
            SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand(Code.Trim(), sql);
            command.Parameters.Add("@u", SqlDbType.NVarChar).Value = username.Text;
            command.Parameters.Add("@n", SqlDbType.NVarChar).Value = name.Text;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lstname.Text;
            command.Parameters.Add("@e", SqlDbType.NVarChar).Value = Email.Text;
            command.Parameters.Add("@ph", SqlDbType.NVarChar).Value = phone.Text;
            command.Parameters.Add("@q", SqlDbType.NVarChar).Value = Q.Text;
            command.Parameters.Add("@a", SqlDbType.NVarChar).Value = A.Text;
            if (checkBox1.Checked)
            {
                command.CommandText += ",Pass=@P";
                command.Parameters.Add("@P", SqlDbType.NVarChar).Value = pass.Text;
            }
            if (image)
            {
                command.CommandText += ",image=@i";
                command.Parameters.Add("@i", SqlDbType.Image).Value = map;
            }
            command.CommandText += (" where id =" + a[LIST.SelectedIndex]);
            sql.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Operation was sucssefully");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bits= new Bitmap(open.FileName);
                ImageConverter converter = new ImageConverter();
                map = converter.ConvertTo(bits, typeof(byte[])) as byte[];
                image = true;
            }
        }
    }
}
