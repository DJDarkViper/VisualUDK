namespace VisualUDK
{
    partial class Splash
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
            this.Menu_ = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_NewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_RecentProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help_CheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.But_NewProject = new System.Windows.Forms.Button();
            this.But_OpenProject = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProjectList = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SplashBrowser = new System.Windows.Forms.WebBrowser();
            this.Menu_.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_
            // 
            this.Menu_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Tools,
            this.Menu_Help});
            this.Menu_.Location = new System.Drawing.Point(0, 0);
            this.Menu_.Name = "Menu_";
            this.Menu_.Size = new System.Drawing.Size(692, 24);
            this.Menu_.TabIndex = 0;
            this.Menu_.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_NewProject,
            this.Menu_File_OpenProject,
            this.Menu_File_RecentProjects,
            this.toolStripSeparator1,
            this.Menu_File_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(37, 20);
            this.Menu_File.Text = "File";
            // 
            // Menu_File_NewProject
            // 
            this.Menu_File_NewProject.Name = "Menu_File_NewProject";
            this.Menu_File_NewProject.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_NewProject.Text = "New Project";
            this.Menu_File_NewProject.Click += new System.EventHandler(this.Menu_File_NewProject_Click);
            // 
            // Menu_File_OpenProject
            // 
            this.Menu_File_OpenProject.Name = "Menu_File_OpenProject";
            this.Menu_File_OpenProject.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_OpenProject.Text = "Open Project";
            this.Menu_File_OpenProject.Click += new System.EventHandler(this.Menu_File_OpenProject_Click);
            // 
            // Menu_File_RecentProjects
            // 
            this.Menu_File_RecentProjects.Name = "Menu_File_RecentProjects";
            this.Menu_File_RecentProjects.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_RecentProjects.Text = "Recent Projects";
            this.Menu_File_RecentProjects.Click += new System.EventHandler(this.Menu_File_RecentProjects_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // Menu_File_Exit
            // 
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_Exit.Text = "Exit";
            this.Menu_File_Exit.Click += new System.EventHandler(this.Menu_File_Exit_Click);
            // 
            // Menu_Tools
            // 
            this.Menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Tools_Options});
            this.Menu_Tools.Name = "Menu_Tools";
            this.Menu_Tools.Size = new System.Drawing.Size(48, 20);
            this.Menu_Tools.Text = "Tools";
            // 
            // Menu_Tools_Options
            // 
            this.Menu_Tools_Options.Name = "Menu_Tools_Options";
            this.Menu_Tools_Options.Size = new System.Drawing.Size(116, 22);
            this.Menu_Tools_Options.Text = "Options";
            this.Menu_Tools_Options.Click += new System.EventHandler(this.Menu_Tools_Options_Click);
            // 
            // Menu_Help
            // 
            this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Help_CheckForUpdates,
            this.toolStripSeparator2,
            this.Menu_Help_About});
            this.Menu_Help.Name = "Menu_Help";
            this.Menu_Help.Size = new System.Drawing.Size(44, 20);
            this.Menu_Help.Text = "Help";
            // 
            // Menu_Help_CheckForUpdates
            // 
            this.Menu_Help_CheckForUpdates.Name = "Menu_Help_CheckForUpdates";
            this.Menu_Help_CheckForUpdates.Size = new System.Drawing.Size(173, 22);
            this.Menu_Help_CheckForUpdates.Text = "Check For Updates";
            this.Menu_Help_CheckForUpdates.Click += new System.EventHandler(this.Menu_Help_CheckForUpdates_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // Menu_Help_About
            // 
            this.Menu_Help_About.Name = "Menu_Help_About";
            this.Menu_Help_About.Size = new System.Drawing.Size(173, 22);
            this.Menu_Help_About.Text = "About";
            this.Menu_Help_About.Click += new System.EventHandler(this.Menu_Help_About_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 335);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.But_NewProject, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.But_OpenProject, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(176, 86);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // But_NewProject
            // 
            this.But_NewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.But_NewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_NewProject.Location = new System.Drawing.Point(3, 3);
            this.But_NewProject.Name = "But_NewProject";
            this.But_NewProject.Size = new System.Drawing.Size(170, 37);
            this.But_NewProject.TabIndex = 0;
            this.But_NewProject.Text = "New Project";
            this.But_NewProject.UseVisualStyleBackColor = true;
            this.But_NewProject.Click += new System.EventHandler(this.But_NewProject_Click);
            // 
            // But_OpenProject
            // 
            this.But_OpenProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.But_OpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_OpenProject.Location = new System.Drawing.Point(3, 46);
            this.But_OpenProject.Name = "But_OpenProject";
            this.But_OpenProject.Size = new System.Drawing.Size(170, 37);
            this.But_OpenProject.TabIndex = 1;
            this.But_OpenProject.Text = "Open Project";
            this.But_OpenProject.UseVisualStyleBackColor = true;
            this.But_OpenProject.Click += new System.EventHandler(this.But_OpenProject_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProjectList);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 249);
            this.panel3.TabIndex = 0;
            // 
            // ProjectList
            // 
            this.ProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectList.Location = new System.Drawing.Point(0, 109);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(176, 140);
            this.ProjectList.TabIndex = 1;
            this.ProjectList.UseCompatibleStateImageBehavior = false;
            this.ProjectList.SelectedIndexChanged += new System.EventHandler(this.ProjectList_SelectedIndexChanged);
            this.ProjectList.DoubleClick += new System.EventHandler(this.ProjectList_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 109);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::VisualUDK.Properties.Resources.unreal_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SplashBrowser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(176, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 335);
            this.panel2.TabIndex = 2;
            // 
            // SplashBrowser
            // 
            this.SplashBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplashBrowser.Location = new System.Drawing.Point(0, 0);
            this.SplashBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.SplashBrowser.Name = "SplashBrowser";
            this.SplashBrowser.Size = new System.Drawing.Size(516, 335);
            this.SplashBrowser.TabIndex = 0;
            this.SplashBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Splash";
            this.Text = "VisualUDK";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.Menu_.ResumeLayout(false);
            this.Menu_.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_About;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button But_NewProject;
        private System.Windows.Forms.Button But_OpenProject;
        private System.Windows.Forms.WebBrowser SplashBrowser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView ProjectList;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_NewProject;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_OpenProject;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_RecentProjects;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_CheckForUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools_Options;


    }
}