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
    public partial class Form1 : Form
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
        string THIS;
        int WHO;
        public Form1(string User,int id)
        {
            InitializeComponent();
            THIS = User;
            WHO = id;
        }
        List<string> a = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            a.Clear();
            Text = THIS;
            SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("select lesson_id,lesson_name from Lesson where teacher=" + WHO , sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                listBox1.Items.Add(reader[1].ToString());
                a.Add(reader[0].ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure ?", "Allert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection sql1 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand command1 = new SqlCommand("delete from lesson where lesson_id=" + a[listBox1.SelectedIndex], sql1);
                    sql1.Open();
                    command1.ExecuteNonQuery();
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }
        List<string> vs = new List<string>();
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) { return; }
            panel1.Visible = true;
            lessonname.Text = "";
            ratio.Text = "";
            students.Items.Clear();
            much.Text = "";
            vs.Clear();
            SqlConnection sql1 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command1 = new SqlCommand("select * from lesson where lesson_id=" + a[listBox1.SelectedIndex], sql1);
            sql1.Open();
            SqlDataReader reader = command1.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            lessonname.Text = reader["lesson_name"].ToString();
            ratio.Text = reader["ratio"].ToString();
            much.Text = (30-int.Parse(reader["much"].ToString())).ToString();
            string Temp= reader["students"].ToString();
            string M = "";int i;
            //1"13"14"15"17"
            reader.Close();
            while (Temp != "")
            {
                i = Temp.IndexOf("\"");
                M = Temp.Substring(0, i);
                Temp = Temp.Remove(0, i + 1);
                SqlConnection sql2 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command2 = new SqlCommand("select id,nam,lastname from Person where id=" + M, sql2);
                sql2.Open();
                SqlDataReader reader2 = command2.ExecuteReader(CommandBehavior.CloseConnection);
                reader2.Read();
                students.Items.Add(reader2[1].ToString() + "," + reader2[2].ToString());
                vs.Add(reader2[0].ToString());
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (students.SelectedIndex == -1)
                return;
            if(MessageBox.Show("are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            vs.Remove(students.SelectedItem.ToString());
            students.Items.Remove(students.SelectedItem);

        }
        bool NEW = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            if (!NEW)
            {
                string temp = "";
                students.SelectedIndex = -1;
                while (students.SelectedIndex < students.Items.Count - 1)
                {
                    students.SelectedIndex++;
                    temp += (vs[students.SelectedIndex] + "\"");
                }
                students.SelectedIndex = -1;
                SqlConnection sql1 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command1 = new SqlCommand("update lesson set students='" + temp + "',much ='" + (30 - int.Parse(much.Text)) + "',ratio='" + ratio.Text + "',lesson_name='" + lessonname.Text + "' where lesson_id=" + a[listBox1.SelectedIndex], sql1);
                sql1.Open();
                command1.ExecuteNonQuery();
                listBox1.SelectedItem = lessonname.Text;
            }
            else
            {
                string temp = "";
                students.SelectedIndex = -1;
                while (students.SelectedIndex < students.Items.Count - 1)
                {
                    students.SelectedIndex++;
                    temp += (vs[students.SelectedIndex] + "\"");
                }
                students.SelectedIndex = -1;
                SqlConnection sql1 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command1 = new SqlCommand("INSERT INTO lesson (teacher, teacher_name, lesson_name,ratio,students,much) VALUES('" + WHO + "','" + Text + "','" + lessonname.Text + "','" + ratio.Text + "','"+temp+ "','" + (30 - int.Parse(much.Text)) + "')", sql1);
                sql1.Open();
                command1.ExecuteNonQuery();
                listBox1.SelectedItem = lessonname.Text;
                NEW = false;
                Form1_Load(this, EventArgs.Empty);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string temp="";
            if(InputBox("","Enter student username :",ref temp) == DialogResult.OK)
            {
                SqlConnection sql2 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command2 = new SqlCommand("select id,nam,lastname from Person where username='" + temp+"'", sql2);
                sql2.Open();
                SqlDataReader reader2 = command2.ExecuteReader(CommandBehavior.CloseConnection);
                if (!reader2.Read())
                {
                    MessageBox.Show("Not found!!!");
                    return;
                }
                if(MessageBox.Show("Are you sure ?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string Y = reader2[0].ToString();
                    for (int i = 0; i < vs.Count;i++)
                    {
                        if (vs[i] == Y)
                        {
                            MessageBox.Show("Student already exists");
                            return;
                        }
                    }
                    vs.Add(Y);
                    students.Items.Add(reader2[1].ToString() + "," + reader2[2].ToString());
                }
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lessonname.Text = "";
            ratio.Text = "";
            students.Items.Clear();
            much.Text = "";NEW = true;
        }
    }
}
