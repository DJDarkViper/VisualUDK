namespace VisualUDK.Popups.Wizards
{
    partial class NewFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.CreateFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(16, 26);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(135, 20);
            this.fileName.TabIndex = 1;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            this.fileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileName_KeyDown);
            // 
            // CreateFile
            // 
            this.CreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateFile.Location = new System.Drawing.Point(51, 52);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(100, 23);
            this.CreateFile.TabIndex = 2;
            this.CreateFile.Text = "Create File";
            this.CreateFile.UseVisualStyleBackColor = true;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ".uc";
            // 
            // NewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 81);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateFile);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewFile";
            this.Text = "VisualUDK - New Class File";
            this.Load += new System.EventHandler(this.NewFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.Label label2;
    }
}