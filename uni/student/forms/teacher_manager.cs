using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using uni.student.forms;

namespace uni.student
{
    
    public partial class teacher_manager : UserControl
    {
        string[] M;
        private int ID;
        string U = "";
        public teacher_manager(int id)
        {
            InitializeComponent();
            ID = id;
            SqlConnection con = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("Select lesson_id,lesson_name from lesson where teacher=" + id, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
                comboBox1.Items.Add(reader[0].ToString()+':'+ reader[1].ToString());
            con.Close();
        }
        int[] marks;
        int number = 0;
        int this_code;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            View.Rows.Clear();
            int lesson_code=int.Parse(comboBox1.SelectedItem.ToString().Substring(0, comboBox1.SelectedItem.ToString().IndexOf(':')));
            this_code = lesson_code;
            SqlConnection con = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("Select students,much from lesson where teacher=" + ID+" AND lesson_id ="+ lesson_code, con);con.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                int q = int.Parse(reader[1].ToString());
                string emp = reader[0].ToString();
                int rt;
                string tg;
                int mark;
                string temp;
                int x;
                marks = new int[q];
                M = new string[q];
                number = q;
                for (int o = 0; o < q; o++)
                {
                    temp = emp.Substring(0, emp.IndexOf('"'));
                    rt = int.Parse(temp);
                    emp=emp.Remove(emp.IndexOf(temp), temp.Length+1);
                    SqlConnection con2 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand command2 = new SqlCommand("Select id,lessons,last_term from WorkBook where id=" + rt, con2);
                    con2.Open();
                    SqlDataReader reader2 = command2.ExecuteReader(CommandBehavior.CloseConnection);
                    reader2.Read();
                    tg = reader2[1].ToString();
                    bool T = true;
                    int past = 0, old = 0, term=int.Parse(reader2[2].ToString());
                    term++;
                    for (int j = 0, i = 0; T == true; j++)
                    {
                        if (tg[j] == '-')
                        {
                            past = old;
                            old = j;
                            i++;
                            if (i >= term)
                            {
                                tg = tg.Substring(past + 1, old - past - 1);
                                T = false;
                            }

                        }
                    }
                    tg = tg.Substring(tg.IndexOf("\"" + lesson_code + ":") + 2 + lesson_code.ToString().Length, 2);
                    mark = int.Parse(tg);
                    SqlConnection con3 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand command3 = new SqlCommand("Select id,nam,lastname from Person where id=" + rt, con3);
                    con3.Open();
                    SqlDataReader reader3 = command3.ExecuteReader(CommandBehavior.CloseConnection);
                    reader3.Read();
                    x = int.Parse(reader2[0].ToString());
                    marks[o] = mark;
                    SqlConnection con4 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand command4 = new SqlCommand("Select message from message where sender1_id=" + rt+" AND sender2_id="+lesson_code, con4);
                    con4.Open();
                    SqlDataReader MESSAGE = command4.ExecuteReader(CommandBehavior.CloseConnection);
                    U = "";
                    if (MESSAGE.Read() == true)
                    {
                        if (MESSAGE[0].ToString() != null)
                        {
                            U = "New Message";
                            M[o] = MESSAGE[0].ToString();
                        }
                    }
                    View.Rows.Add(x, reader3[1].ToString() + "," + reader3[2].ToString(), mark,U);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for(int p = 0; p < number; p++)
            {
                if (int.Parse(View.Rows[p].Cells[2].Value.ToString())!=marks[p])
                {
                    SqlConnection connection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand command = new SqlCommand("select lessons,last_term from WorkBook where id =" + int.Parse(View.Rows[p].Cells[0].Value.ToString()),connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    reader.Read();
                    string temp = reader[0].ToString(),data;
                    data = temp;
                    bool T = true;
                    int past = 0, old = 0, term = int.Parse(reader[1].ToString());
                    term++;
                    for (int j = 0, i = 0; T == true; j++)
                    {
                        if (temp[j] == '-')
                        {
                            past = old;
                            old = j;
                            i++;
                            if (i >= term)
                            {
                                temp = temp.Substring(past + 1, old - past - 1);
                                T = false;
                            }

                        }
                    }
                    int B = int.Parse(View.Rows[p].Cells[2].Value.ToString());
                    string BUG;
                    string BUG2;
                    if (B >= 10)
                        BUG = B.ToString();
                    else
                        BUG = "0" + B.ToString();
                    string c = this_code.ToString() + ":" + BUG;
                    if (marks[p] < 10)
                        BUG2 = "0" + marks[p].ToString();
                    else
                        BUG2 = marks[p].ToString();
                    string b = this_code.ToString() + ":" +BUG2;
                    string a = temp.Replace(b, c);
                    data = data.Replace(temp,a);
                    SqlConnection connection2 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand command2 = new SqlCommand("update WorkBook set lessons = '" + data + "' where id =" + int.Parse(View.Rows[p].Cells[0].Value.ToString()), connection2);
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    connection2.Close();
                    connection.Close();
                    //command2.BeginExecuteNonQuery();
                }
            }
            Button1_Click(null, null);
        }

        private void View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (View.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    MessageBox.Show(M[e.RowIndex]);
                    if(MessageBox.Show("do you want to answer this message ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        input IN = new input(this_code, int.Parse(View.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        IN.ShowDialog();
                        if (IN.Result == true)
                            MessageBox.Show("Your message was sended");
                        else
                            MessageBox.Show("Fail");
                    }
                }
            }
        }
    }
}
