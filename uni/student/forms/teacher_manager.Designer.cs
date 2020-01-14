namespace uni.student
{
    partial class teacher_manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.View = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.studentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
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
            this.studentid,
            this.Studentname,
            this.mark,
            this.message});
            this.View.EnableHeadersVisualStyles = false;
            this.View.Location = new System.Drawing.Point(69, 57);
            this.View.MultiSelect = false;
            this.View.Name = "View";
            this.View.RowHeadersVisible = false;
            this.View.ShowCellErrors = false;
            this.View.ShowCellToolTips = false;
            this.View.ShowEditingIcon = false;
            this.View.ShowRowErrors = false;
            this.View.Size = new System.Drawing.Size(416, 300);
            this.View.TabIndex = 10;
            this.View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 10F);
            this.button1.Location = new System.Drawing.Point(179, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "For";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "&Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // studentid
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentid.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentid.HeaderText = "Student id";
            this.studentid.Name = "studentid";
            this.studentid.ReadOnly = true;
            this.studentid.Width = 85;
            // 
            // Studentname
            // 
            this.Studentname.HeaderText = "Student name";
            this.Studentname.Name = "Studentname";
            this.Studentname.ReadOnly = true;
            this.Studentname.Width = 150;
            // 
            // mark
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F);
            this.mark.DefaultCellStyle = dataGridViewCellStyle4;
            this.mark.HeaderText = "Mark";
            this.mark.MaxInputLength = 2;
            this.mark.Name = "mark";
            this.mark.Width = 60;
            // 
            // message
            // 
            this.message.HeaderText = "message";
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.message.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.message.Width = 110;
            // 
            // teacher_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "teacher_manager";
            this.Size = new System.Drawing.Size(561, 406);
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView View;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studentname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewButtonColumn message;
    }
}
