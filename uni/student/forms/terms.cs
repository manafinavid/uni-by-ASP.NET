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
    public partial class terms : Form
    {
        char o;
        public terms()
        {
            InitializeComponent();
        }
        List<string> A = new List<string>();
        private void Button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Size = new System.Drawing.Size(561, 406);
            Size = new System.Drawing.Size(580, 450);
            panel2.Location = new System.Drawing.Point(0,0);
            panel2.Controls.Add(new uni.student.manager(int.Parse(A[LIST.SelectedIndex])));
        }

        private void Terms_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(325, 82);
            SqlConnection sql = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("select nam,lastname,username,id from Person where type='s'", sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                LIST.Items.Add(reader[0].ToString() + "," + reader[1].ToString() + " : " + reader[2].ToString());
                A.Add(reader[3].ToString());
            }
        }
    }
}
