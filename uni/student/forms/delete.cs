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
    public partial class delete : Form
    {
        char T;
        public delete(char I)
        {
            InitializeComponent();
            T = I;
        }
        List<string> a = new List<string>();
        private void Delete_Load(object sender, EventArgs e)
        {
            LIST.Items.Clear();
            this.Size = new System.Drawing.Size(327, 85);
            SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("select username,nam,lastname,id from Person where type='" + T + "'", sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                LIST.Items.Add(reader[1].ToString() + "," + reader[2].ToString() + " : " + reader[0].ToString());
                string temp = reader[3].ToString();
                a.Add(temp);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ?", "Allert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string TEMP;
                SqlConnection sql1 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command1 = new SqlCommand("select id from Person where id="+a[LIST.SelectedIndex]+" AND type='"+T+"'", sql1);
                sql1.Open();
                SqlDataReader reader = command1.ExecuteReader(CommandBehavior.CloseConnection);
                reader.Read();
                TEMP = reader[0].ToString();
                SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand command = new SqlCommand("delete from Person where Id="+TEMP, sql);
                sql.Open();
                command.ExecuteNonQuery();
                if (T == 's')
                {
                    SqlConnection sq2 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand command2 = new SqlCommand("delete from WorkBook where Id=" + TEMP, sq2);
                    sq2.Open();
                    Delete_Load(this, EventArgs.Empty);
                }
            }
        }
    }
}
