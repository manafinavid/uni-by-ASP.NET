using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using uni.student.forms;

namespace uni
{
    public partial class students : Form
    {
        private int ID;
        public students(int Id,char type)
        {
            ID = Id;
            InitializeComponent();
            switch(type)
            {
                case 'a':
                    witem.Visible = false;
                    newTermToolStripMenuItem.Visible = false;
                    mItem.Visible = false;
                    Text = "Manager Form";
                    break;
                case 's':
                    fileToolStripMenuItem.Visible = false;
                    Text = "Student Form";
                    mItem.Visible = false;
                    newTermToolStripMenuItem.Enabled = uni.Properties.Settings.Default.newterm;
                    break;
                case 't':
                    newTermToolStripMenuItem.Visible = false;
                    fileToolStripMenuItem.Visible = false;
                    Text = "Teacher Form";
                    witem.Visible = false;
                    break;
                default:
                    MessageBox.Show("An error has occurred!!!");
                    Application.Exit();
                    break;
            }
        }
        public static void _Panel(Control P)
        { 
       //     students.panel1.Controls.Add(P { });
        }
        private void UserSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new setting (ID){ });
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Students_Load(object sender, EventArgs e)
        {
            if(uni.Properties.Settings.Default.newterm)
            {
                startNewTermToolStripMenuItem.Text = "&End of unit selection";
            }
        }

        private void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void WorkbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new uni.WorkBook.WorkBook(ID) { });
        }

        private void MItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new uni.student.teacher_manager(ID){ });
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            students sd = new students(13, 's');
            sd.Show();
        }

        private void Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NewTermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new student.manager(ID) { });
        }

        private void DeletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete D = new delete('a');
            D.ShowDialog();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD Add = new ADD(1);
            Add.ShowDialog();
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ADD Add = new ADD(2);
            Add.ShowDialog();
        }

        private void AddToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ADD Add = new ADD(3);
            Add.ShowDialog();
        }







        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit E = new Edit('a');
            E.ShowDialog();
        }

        private void LessonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lesson_M VS = new lesson_M();
            VS.ShowDialog();
        }

        private void EditToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Edit E = new Edit('s');
            E.ShowDialog();
        }

        private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit E = new Edit('s');
            E.ShowDialog();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete D = new delete('t');
            D.ShowDialog();
        }

        private void DeleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            delete D = new delete('s');
            D.ShowDialog();
        }

        private void NewTermToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            terms D = new terms();
            D.ShowDialog();
        }

        private void StartNewTermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uni.Properties.Settings.Default.newterm = !uni.Properties.Settings.Default.newterm;
            if (uni.Properties.Settings.Default.newterm)
            {
                startNewTermToolStripMenuItem.Text = "&End of unit selection";
            }
            else
            {
                startNewTermToolStripMenuItem.Text = "&Start new term";
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student.AboutBox1 about = new student.AboutBox1();
            about.ShowDialog();
        }
    }
}
