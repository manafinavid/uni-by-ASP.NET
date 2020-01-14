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
    public partial class input : Form
    {
        int S, R;
        public bool Result;
        public input(int sender ,int receiver)
        {
            InitializeComponent();
            S = sender;
            R = receiver;
        }

        private void Input_Box_Load(object sender, EventArgs e)
        {
            Result = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand(string.Format("insert into message (sender1_id,sender2_id,message,tag) VALUES ('{0}','{1}','{2}','{3}')", S, R, richTextBox1.Text, '0'), connection);
            connection.Open();
            command.ExecuteNonQuery();
            Result = true;
            this.Close();
        }
    }
}
