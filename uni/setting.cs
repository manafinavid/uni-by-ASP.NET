using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace uni
{
    public partial class setting : UserControl
    {
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        private int odf;
        public setting(int id)
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand cmd = new SqlCommand("Select username,nam,lastname,email,phone,Q,A,image from person where Id=" + id, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            bool i = reader.Read();
            if (i == true)
            {
                username.Text = reader[0].ToString();
                name.Text = reader[1].ToString();
                lastname.Text = reader[2].ToString();
                email.Text = reader[3].ToString();
                Phone.Text = reader[4].ToString();
                security.Text = reader[5].ToString();
                answer.Text = reader[6].ToString();
                try
                {
                    ImageConverter converter = new ImageConverter();
                    byte[] test = (byte[])reader[7];
                    userimage.Image = (Image)converter.ConvertFrom(test);
                    odf = id;
                }
                catch { }
            }
            else
            {
                Application.Exit();
            }
            con.Close();
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar!=8)
                e.Handled = !char.IsDigit(e.KeyChar) ? true : false;
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                userimage.Load(open.FileName);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            string val = "";
           if( InputBox("","Enter your Pass",ref val) == DialogResult.OK)
            {
                SqlCommand command = new SqlCommand("select Pass from person where Id ="+odf,con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read() == true)
                {
                    if (val == reader[0].ToString())
                    {
                        reader.Close();
                        con.Open();
                        command.Connection = con;
                        string CommandText;
                        if (checkBox1.Checked = true && password.Text != "")
                        {
                            CommandText = "update person SET username='{0}',Pass='{1}',nam='{2}',lastname='{3}',email='{4}',phone='{5}',Q='{6}',A='{7}',image=@i where Id="+odf;
                            command.CommandText = string.Format(CommandText, username.Text, password.Text, name.Text, lastname.Text, email.Text, Phone.Text, security.Text, answer.Text);
                            ImageConverter converter = new ImageConverter();
                            byte[] test = (byte[])converter.ConvertTo(userimage.Image, typeof(byte[]));
                            command.Parameters.Add("@i", SqlDbType.Image).Value = test;
                            command.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            CommandText = "update person SET username='{0}',nam='{1}',lastname='{2}',email='{3}',phone='{4}',Q='{5}',A='{6}',image=@i where Id=" + odf;
                            command.CommandText = string.Format(CommandText, username.Text, name.Text, lastname.Text, email.Text, Phone.Text, security.Text, answer.Text);
                            ImageConverter converter = new ImageConverter();
                            byte[] test = (byte[])converter.ConvertTo(userimage.Image, typeof(byte[]));
                            command.Parameters.Add("@i", SqlDbType.Image).Value = test;
                            command.ExecuteNonQuery();
                            con.Close();
                        }
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@i";
                        param.Value = userimage.Image;
                        command.Parameters.Add(param);
                    }
                }
                else
                    MessageBox.Show("An error has occurred!!!");
            }
            con.Close();

        }
        bool o = true;
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.ReadOnly=!o;
            o =!o;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }
    }
}
