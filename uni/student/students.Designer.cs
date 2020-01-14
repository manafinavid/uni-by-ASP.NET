namespace uni
{
    partial class students
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newTermToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewTermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItem = new System.Windows.Forms.ToolStripMenuItem();
            this.witem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 406);
            this.panel1.TabIndex = 1;
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.userSettingsToolStripMenuItem.Text = "&User settings";
            this.userSettingsToolStripMenuItem.Click += new System.EventHandler(this.UserSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newTermToolStripMenuItem,
            this.mItem,
            this.witem,
            this.userSettingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managersToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.startNewTermToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // managersToolStripMenuItem
            // 
            this.managersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deletToolStripMenuItem});
            this.managersToolStripMenuItem.Name = "managersToolStripMenuItem";
            this.managersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.managersToolStripMenuItem.Text = "Managers";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deletToolStripMenuItem
            // 
            this.deletToolStripMenuItem.Name = "deletToolStripMenuItem";
            this.deletToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deletToolStripMenuItem.Text = "Delete";
            this.deletToolStripMenuItem.Click += new System.EventHandler(this.DeletToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.lessonToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // lessonToolStripMenuItem
            // 
            this.lessonToolStripMenuItem.Name = "lessonToolStripMenuItem";
            this.lessonToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.lessonToolStripMenuItem.Text = "Lesson";
            this.lessonToolStripMenuItem.Click += new System.EventHandler(this.LessonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem3,
            this.editToolStripMenuItem3,
            this.deleteToolStripMenuItem2,
            this.newTermToolStripMenuItem1});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem3.Text = "Add";
            this.addToolStripMenuItem3.Click += new System.EventHandler(this.AddToolStripMenuItem3_Click);
            // 
            // editToolStripMenuItem3
            // 
            this.editToolStripMenuItem3.Name = "editToolStripMenuItem3";
            this.editToolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem3.Text = "Edit";
            this.editToolStripMenuItem3.Click += new System.EventHandler(this.EditToolStripMenuItem3_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.DeleteToolStripMenuItem2_Click);
            // 
            // newTermToolStripMenuItem1
            // 
            this.newTermToolStripMenuItem1.Name = "newTermToolStripMenuItem1";
            this.newTermToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.newTermToolStripMenuItem1.Text = "Terms";
            this.newTermToolStripMenuItem1.Click += new System.EventHandler(this.NewTermToolStripMenuItem1_Click);
            // 
            // startNewTermToolStripMenuItem
            // 
            this.startNewTermToolStripMenuItem.Name = "startNewTermToolStripMenuItem";
            this.startNewTermToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.startNewTermToolStripMenuItem.Text = "&Start new term";
            this.startNewTermToolStripMenuItem.Click += new System.EventHandler(this.StartNewTermToolStripMenuItem_Click);
            // 
            // newTermToolStripMenuItem
            // 
            this.newTermToolStripMenuItem.Name = "newTermToolStripMenuItem";
            this.newTermToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.newTermToolStripMenuItem.Text = "new term";
            this.newTermToolStripMenuItem.Click += new System.EventHandler(this.NewTermToolStripMenuItem_Click);
            // 
            // mItem
            // 
            this.mItem.Name = "mItem";
            this.mItem.Size = new System.Drawing.Size(110, 20);
            this.mItem.Text = "&Manage students";
            this.mItem.Click += new System.EventHandler(this.MItem_Click);
            // 
            // witem
            // 
            this.witem.Name = "witem";
            this.witem.Size = new System.Drawing.Size(74, 20);
            this.witem.Text = "&Workbook";
            this.witem.Click += new System.EventHandler(this.WorkbookToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "students";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Students_FormClosed);
            this.Load += new System.EventHandler(this.Students_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem witem;
        private System.Windows.Forms.ToolStripMenuItem mItem;
        private System.Windows.Forms.ToolStripMenuItem newTermToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newTermToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lessonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewTermToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

