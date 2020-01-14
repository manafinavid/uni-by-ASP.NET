namespace uni.student.forms
{
    partial class delete
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
            this.LIST = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LIST);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 37;
            // 
            // LIST
            // 
            this.LIST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LIST.FormattingEnabled = true;
            this.LIST.Location = new System.Drawing.Point(6, 6);
            this.LIST.Name = "LIST";
            this.LIST.Size = new System.Drawing.Size(206, 21);
            this.LIST.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "&Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 46);
            this.Controls.Add(this.panel1);
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox LIST;
        private System.Windows.Forms.Button button3;
    }
}