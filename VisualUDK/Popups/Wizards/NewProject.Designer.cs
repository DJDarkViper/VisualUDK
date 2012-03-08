namespace VisualUDK.Popups.Wizards
{
    partial class NewProject
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_CreateProject = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.systemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classInherits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isCreateClass = new System.Windows.Forms.CheckBox();
            this.isAttemptToConfigure = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 56);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::VisualUDK.Properties.Resources.header_newproject;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.but_CreateProject);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.isAttemptToConfigure);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 336);
            this.panel2.TabIndex = 1;
            // 
            // but_CreateProject
            // 
            this.but_CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_CreateProject.Location = new System.Drawing.Point(281, 291);
            this.but_CreateProject.Name = "but_CreateProject";
            this.but_CreateProject.Size = new System.Drawing.Size(142, 37);
            this.but_CreateProject.TabIndex = 8;
            this.but_CreateProject.Text = "Create Project";
            this.but_CreateProject.UseVisualStyleBackColor = true;
            this.but_CreateProject.Click += new System.EventHandler(this.but_CreateProject_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.systemName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.projectName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 144);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Settings";
            // 
            // systemName
            // 
            this.systemName.Location = new System.Drawing.Point(31, 98);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(374, 20);
            this.systemName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(13, 47);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(392, 20);
            this.projectName.TabIndex = 1;
            this.projectName.TextChanged += new System.EventHandler(this.projectName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "System Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classInherits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.className);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.isCreateClass);
            this.groupBox1.Location = new System.Drawing.Point(12, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Class";
            // 
            // classInherits
            // 
            this.classInherits.Location = new System.Drawing.Point(202, 60);
            this.classInherits.Name = "classInherits";
            this.classInherits.Size = new System.Drawing.Size(203, 20);
            this.classInherits.TabIndex = 9;
            this.classInherits.Text = "Actor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inherits";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(13, 60);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(179, 20);
            this.className.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class Name";
            // 
            // isCreateClass
            // 
            this.isCreateClass.AutoSize = true;
            this.isCreateClass.Checked = true;
            this.isCreateClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isCreateClass.Location = new System.Drawing.Point(13, 19);
            this.isCreateClass.Name = "isCreateClass";
            this.isCreateClass.Size = new System.Drawing.Size(110, 17);
            this.isCreateClass.TabIndex = 5;
            this.isCreateClass.Text = "Create initial class";
            this.isCreateClass.UseVisualStyleBackColor = true;
            // 
            // isAttemptToConfigure
            // 
            this.isAttemptToConfigure.AutoSize = true;
            this.isAttemptToConfigure.Checked = true;
            this.isAttemptToConfigure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isAttemptToConfigure.Location = new System.Drawing.Point(12, 162);
            this.isAttemptToConfigure.Name = "isAttemptToConfigure";
            this.isAttemptToConfigure.Size = new System.Drawing.Size(220, 17);
            this.isAttemptToConfigure.TabIndex = 4;
            this.isAttemptToConfigure.Text = "Attempt to configure engine automatically";
            this.isAttemptToConfigure.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "/";
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewProject";
            this.Text = "New UDK Project Wizard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox systemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isAttemptToConfigure;
        private System.Windows.Forms.CheckBox isCreateClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classInherits;
        private System.Windows.Forms.Button but_CreateProject;
        private System.Windows.Forms.Label label5;
    }
}