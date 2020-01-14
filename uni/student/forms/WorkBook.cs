using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using uni.student.forms;

namespace uni.WorkBook
{
    public partial class WorkBook : UserControl
    {
        int ID;
        string[] M;
        struct lesson
        {
            public int index;
            public int[] marks;
            public int[] ratio;
            public string[] lesson_name;
            public string[] teacher_name;
            public int[] lesson_id;
        }
        int BUG_fix=0;
        lesson Read_Lesson(int term)
        {
            BUG_fix++;
            SqlConnection con = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand cmd = new SqlCommand("select lessons from WorkBook where id=" + ID, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.Read() == true)
            {
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
        public WorkBook(int id)
        {
            InitializeComponent();
            ID = id;
            SqlConnection con = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
            SqlCommand cmd = new SqlCommand("select last_term from WorkBook where id=" + ID, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.Read() == true)
            {
                int lst = int.Parse(reader[0].ToString());
                listBox1.Minimum = 1;
                listBox1.Maximum = lst;
            }
            else
            {
                MessageBox.Show("An error has occurred!!!");
            }
            reader.Close();
            con.Close();
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            View.Rows.Clear();
            string U = "";
            int w = (int)listBox1.Value;
            lesson O= Read_Lesson(w);
            M = new string[O.index];
            for (int o = 0; o < O.index; o++)
            {
                U = "";
                SqlConnection connection = new SqlConnection(uni.Properties.Settings.Default.DataConnectionString);
                SqlCommand cmd = new SqlCommand("select message from message where sender1_id=" + ID + " AND sender2_id=" + O.lesson_id[o], connection);connection.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    M[o] = reader[0].ToString();
                    U = "Messgae";
                }
                View.Rows.Add(O.lesson_id[o], O.lesson_name[o], O.ratio[o],O.teacher_name[o] ,O.marks[o], "protest",U);
            }
            View.CellClick += View_CellClick;
        }
        int BUG = 0;
        private void View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (BUG == 0)
                {
                    string temp = View.Rows[e.RowIndex].Cells[0].Value.ToString();
                    input IN= new input(ID,int.Parse(temp));
                    IN.Show();
                    BUG++;
                }
                else if (BUG < BUG_fix) { 
                    BUG++;
                    if(BUG == BUG_fix)
                    {
                        BUG = 0;
                    }
                }
                else
                    BUG = 0;
            }
            if (e.ColumnIndex == 6&& View.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()!="")
            {
                if (BUG == 0)
                {
                    MessageBox.Show(M[e.RowIndex]);
                }
                else if (BUG < BUG_fix)
                {
                    BUG++;
                    if (BUG == BUG_fix)
                    {
                        BUG = 0;
                    }
                }
                else
                    BUG = 0;
            }
        }
        private void WorkBook_Load(object sender, System.EventArgs e)
        {

        }
    }
}
