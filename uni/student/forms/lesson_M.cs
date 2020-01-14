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
    public partial class lesson_M : Form
    {
        public lesson_M()
        {
            InitializeComponent();
        }
        List<string> a = new List<string>();
        List<string> b = new List<string>();
        private void Lesson_M_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("select username,nam,lastname,id from Person where type='t'", sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                LIST.Items.Add(reader[1].ToString() + "," + reader[2].ToString() + " : " + reader[0].ToString());
                b.Add(reader[1].ToString() + "," + reader[2].ToString());
                string temp = reader[3].ToString();
                a.Add(temp);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 VS = new Form1(b[LIST.SelectedIndex], int.Parse(a[LIST.SelectedIndex]));
            VS.ShowDialog();
            this.Close();
        }
    }
}
