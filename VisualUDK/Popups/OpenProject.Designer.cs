namespace VisualUDK.Popups
{
    partial class OpenProject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.myProjects = new System.Windows.Forms.ListView();
            this.availableProjects = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.myProjects);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Projects";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.availableProjects);
            this.groupBox2.Location = new System.Drawing.Point(13, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Projects";
            // 
            // myProjects
            // 
            this.myProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myProjects.Location = new System.Drawing.Point(3, 16);
            this.myProjects.Name = "myProjects";
            this.myProjects.Size = new System.Drawing.Size(239, 176);
            this.myProjects.TabIndex = 0;
            this.myProjects.UseCompatibleStateImageBehavior = false;
            // 
            // availableProjects
            // 
            this.availableProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableProjects.Location = new System.Drawing.Point(3, 16);
            this.availableProjects.Name = "availableProjects";
            this.availableProjects.Size = new System.Drawing.Size(238, 281);
            this.availableProjects.TabIndex = 0;
            this.availableProjects.UseCompatibleStateImageBehavior = false;
            // 
            // OpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OpenProject";
            this.Text = "Open Existing Project";
            this.Load += new System.EventHandler(this.OpenProject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView myProjects;
        private System.Windows.Forms.ListView availableProjects;
    }
}