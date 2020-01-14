namespace uni.WorkBook
{
    partial class WorkBook
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.NumericUpDown();
            this.View = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report = new System.Windows.Forms.DataGridViewButtonColumn();
            this.answer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F);
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Term :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 10F);
            this.button1.Location = new System.Drawing.Point(106, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 11F);
            this.listBox1.Location = new System.Drawing.Point(65, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(35, 27);
            this.listBox1.TabIndex = 3;
            // 
            // View
            // 
            this.View.AllowUserToAddRows = false;
            this.View.AllowUserToDeleteRows = false;
            this.View.AllowUserToOrderColumns = true;
            this.View.AllowUserToResizeColumns = false;
            this.View.AllowUserToResizeRows = false;
            this.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.lsn,
            this.ratio,
            this.Teacher,
            this.mark,
            this.report,
            this.answer});
            this.View.EnableHeadersVisualStyles = false;
            this.View.Location = new System.Drawing.Point(17, 50);
            this.View.MultiSelect = false;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.RowHeadersVisible = false;
            this.View.ShowCellErrors = false;
            this.View.ShowCellToolTips = false;
            this.View.ShowEditingIcon = false;
            this.View.ShowRowErrors = false;
            this.View.Size = new System.Drawing.Size(530, 300);
            this.View.TabIndex = 6;
            // 
            // code
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.code.DefaultCellStyle = dataGridViewCellStyle1;
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 70;
            // 
            // lsn
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F);
            this.lsn.DefaultCellStyle = dataGridViewCellStyle2;
            this.lsn.HeaderText = "Lesson";
            this.lsn.Name = "lsn";
            this.lsn.ReadOnly = true;
            this.lsn.Width = 90;
            // 
            // ratio
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F);
            this.ratio.DefaultCellStyle = dataGridViewCellStyle3;
            this.ratio.HeaderText = "Ratio";
            this.ratio.Name = "ratio";
            this.ratio.ReadOnly = true;
            this.ratio.Width = 45;
            // 
            // Teacher
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F);
            this.Teacher.DefaultCellStyle = dataGridViewCellStyle4;
            this.Teacher.HeaderText = "Teacher";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            this.Teacher.Width = 130;
            // 
            // mark
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F);
            this.mark.DefaultCellStyle = dataGridViewCellStyle5;
            this.mark.HeaderText = "Mark";
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            this.mark.Width = 50;
            // 
            // report
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F);
            this.report.DefaultCellStyle = dataGridViewCellStyle6;
            this.report.HeaderText = "protest";
            this.report.Name = "report";
            this.report.ReadOnly = true;
            this.report.Width = 70;
            // 
            // answer
            // 
            this.answer.HeaderText = "answer";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.answer.Width = 70;
            // 
            // WorkBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.View);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "WorkBook";
            this.Size = new System.Drawing.Size(561, 406);
            this.Load += new System.EventHandler(this.WorkBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown listBox1;
        private System.Windows.Forms.DataGridView View;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewButtonColumn report;
        private System.Windows.Forms.DataGridViewButtonColumn answer;
    }
}
