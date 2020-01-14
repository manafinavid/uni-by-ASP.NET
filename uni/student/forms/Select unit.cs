using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace uni.student
{
    public partial class manager : UserControl
    {
        string lable1_= "Maximum units : {0}";
        int max_unit=0;
        int OID=0;
        public manager(int ID)
        {

            InitializeComponent();
            OID = ID;
            SqlConnection connection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand command = new SqlCommand("select lessons from WorkBook where id=" + ID, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                string data = reader[0].ToString();
                if (data != "")
                {
                    reader.Close();
                    connection.Close();
                    lesson temp=  Read_Lesson(ID);
                    float mark=0;
                    float number=0;
                    for(int i = 0; i < temp.index; i++)
                    {
                        mark += temp.marks[i]*temp.ratio[i];
                        number += temp.ratio[i];
                    }
                    mark /= number;
                    if (mark >= 17)
                        max_unit = 24;
                    else if(mark > 12)
                        max_unit = 20;
                    else
                        max_unit = 10;
                }
                else
                {
                    max_unit = 20;
                }
                label1.Text = string.Format(lable1_.Trim(), max_unit);
            }
            SqlConnection con2 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand cmd2 = new SqlCommand("select * from lesson ", con2);
            con2.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader(CommandBehavior.CloseConnection);
            int X = 0;
            while (reader2.Read())
            {
                dataGridView1.Rows.Add("",reader2["lesson_name"].ToString(),reader2["lesson_id"].ToString(), reader2["teacher_name"].ToString(), reader2["ratio"].ToString(),30-int.Parse(reader2["much"].ToString()));
                X++;
            }
            C = new bool[X];
        }
        struct lesson
        {
            public int index;
            public int[] marks;
            public int[] ratio;
            public string[] lesson_name;
            public string[] teacher_name;
            public int[] lesson_id;
        }
        int BUG_fix = 0;
        lesson Read_Lesson(int ID)
        {
            int term;
            BUG_fix++;
            SqlConnection con = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand cmd = new SqlCommand("select lessons,last_term from WorkBook where id=" + ID, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.Read() == true)
            {
                term =int.Parse(reader[1].ToString());
                string text = reader[0].ToString();
                lesson Lesen;
                Lesen.lesson_id = new int[24];
                Lesen.ratio = new int[24];
                Lesen.marks = new int[24];
                int past = 0, old = 0;
                bool T = true;
                term++;
                for (int j = 0, i = 0; T == true; j++)
                {
                    if (text[j] == '-')
                    {
                        past = old;
                        old = j;
                        i++;
                        if (i >= term)
                        {
                            text = text.Substring(past + 1, old - past - 1);
                            T = false;
                        }//-"0001:20"0002:2:20"0003:1:20"-"0678:1:08"4661:1:05"9871:2:09"-

                    }
                }
                int index = 0;
                int bug = 0;
                for (int i = 0; text != ""; i++)
                {
                    index++;
                    int temp;
                    temp = text.IndexOf(':');
                    string h = text.Substring(1 - bug, temp - 1 + bug);
                    Lesen.lesson_id[i] = int.Parse(h);
                    text = text.Substring(temp + 1);
                    temp = text.IndexOf('"');
                    Lesen.marks[i] = int.Parse(text.Substring(0, temp));
                    text = text.Substring(temp + 1);
                    bug = 1;
                }
                con.Close();

                Lesen.index = index;
                Lesen.lesson_name = new string[index];
                Lesen.teacher_name = new string[index];
                for (int row = 0; row < index; row++)
                {
                    SqlConnection con2 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand cmd2 = new SqlCommand("select lesson_name,ratio,teacher_name from lesson where lesson_id=" + Lesen.lesson_id[row], con2);
                    con2.Open();
                    SqlDataReader reader2 = cmd2.ExecuteReader(CommandBehavior.CloseConnection);
                    reader2.Read();
                    Lesen.ratio[row] = (int)reader2[1];
                    Lesen.lesson_name[row] = reader2[0].ToString();
                    Lesen.teacher_name[row] = reader2[2].ToString();
                    con2.Close();

                }
                return Lesen;
            }
            else
                MessageBox.Show("An error has occurred!!!");
            return new lesson { };
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(dataGridView1.Rows[e.ColumnIndex].Cells[0].Value.ToString());
        }
        bool[] C;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int R = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == "O")
                {
                    max_unit += R;
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = "";
                    label1.Text = string.Format(lable1_, max_unit);
                }
                else if(max_unit>=R)
                {
                    max_unit -= R;
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = "O";
                    label1.Text = string.Format(lable1_, max_unit);
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //"678:08"4661:05"9871:09"-
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string data = "\"";
                List<int> cods=new List<int>();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "O")
                    {
                        data += (dataGridView1.Rows[i].Cells[2].Value.ToString() + ":00\"");
                        cods.Add(int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                    }
                }
                data += "-";
                string data_;
                SqlConnection con2 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand cmd2 = new SqlCommand("select lessons,last_term from WorkBook where id="+OID, con2);
                con2.Open();
                SqlDataReader reader = cmd2.ExecuteReader(CommandBehavior.CloseConnection);
                reader.Read();
                data_= reader[0].ToString();
                int last_term=int.Parse( reader[1].ToString());
                con2.Close();
                SqlConnection con3 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand cmd3 = new SqlCommand("update WorkBook set lessons='"+data_+data+"', last_term='"+(last_term+1)+"' where id=" + OID, con3);
                con3.Open();
                cmd3.ExecuteNonQuery();
                string P;
                string Z;
                for (int i = 0; i < cods.Count; i++)
                {
                    SqlConnection con4 = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    SqlCommand cmd4 = new SqlCommand("select much,students from lesson where lesson_id= "+cods[i], con4);
                    con4.Open();
                    SqlDataReader reader1 = cmd4.ExecuteReader(CommandBehavior.CloseConnection);
                    reader1.Read();
                    P = reader1[0].ToString();
                    Z = reader1[1].ToString();
                    reader1.Close();
                    con4.Close();
                    SqlConnection copy = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                    copy.Open();
                    SqlCommand mcopy = new SqlCommand("update lesson set much='" +(int.Parse(P)+1 )+ "',students='"+(Z+OID)+"' where lesson_id=" + i,copy);
                    //copy.Open();
                    mcopy.ExecuteNonQuery();
                }
                MessageBox.Show("Operation was successfully");
            }
        }
    }
}
