namespace uni.student
{
    partial class manager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.less = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IS,
            this.less,
            this.lessonid,
            this.Teacher,
            this.Ratio,
            this.capacity});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(519, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // IS
            // 
            this.IS.HeaderText = "IS";
            this.IS.Name = "IS";
            this.IS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS.Width = 30;
            // 
            // less
            // 
            this.less.HeaderText = "lesson name";
            this.less.Name = "less";
            this.less.ReadOnly = true;
            this.less.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.less.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.less.Width = 150;
            // 
            // lessonid
            // 
            this.lessonid.HeaderText = "lesson id";
            this.lessonid.Name = "lessonid";
            this.lessonid.ReadOnly = true;
            this.lessonid.Width = 80;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Teacher";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            this.Teacher.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Teacher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Teacher.Width = 150;
            // 
            // Ratio
            // 
            this.Ratio.HeaderText = "Ratio";
            this.Ratio.Name = "Ratio";
            this.Ratio.ReadOnly = true;
            this.Ratio.Width = 50;
            // 
            // capacity
            // 
            this.capacity.HeaderText = "capacity";
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.Width = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "manager";
            this.Size = new System.Drawing.Size(561, 406);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn IS;
        private System.Windows.Forms.DataGridViewTextBoxColumn less;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.Button button1;
    }
}
