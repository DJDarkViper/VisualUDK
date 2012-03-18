namespace VisualUDK
{
    partial class ProjectEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditor));
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.Status_ = new System.Windows.Forms.StatusStrip();
            this.Strip_ = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_NewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_CloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_CloseProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_SaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_RecentFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_RecentProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_QuickReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_QuickFind = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Project = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Project_AddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Project_AddNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Project_Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Project_Compile_JustCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Project_Compile_Editor = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Project_Compile_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help_Documentation = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help_Documentation_Search = new System.Windows.Forms.ToolStripTextBox();
            this.Menu_Help_CheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CodeEditor = new ScintillaNET.Scintilla();
            this.ProjectStuff = new System.Windows.Forms.TabControl();
            this.Window_Console = new System.Windows.Forms.TabPage();
            this.Window_Errors = new System.Windows.Forms.TabPage();
            this.ProjectBrowser = new System.Windows.Forms.TreeView();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.OutputConsole = new System.Windows.Forms.RichTextBox();
            this.Strip_.SuspendLayout();
            this.Menu_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).BeginInit();
            this.ProjectStuff.SuspendLayout();
            this.Window_Console.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status_
            // 
            this.Status_.Location = new System.Drawing.Point(0, 617);
            this.Status_.Name = "Status_";
            this.Status_.Size = new System.Drawing.Size(955, 22);
            this.Status_.TabIndex = 1;
            this.Status_.Text = "statusStrip1";
            // 
            // Strip_
            // 
            this.Strip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Edit,
            this.Menu_View,
            this.Menu_Project,
            this.Menu_Tools,
            this.Menu_Help});
            this.Strip_.Location = new System.Drawing.Point(0, 0);
            this.Strip_.Name = "Strip_";
            this.Strip_.Size = new System.Drawing.Size(955, 24);
            this.Strip_.TabIndex = 2;
            this.Strip_.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_NewProject,
            this.Menu_File_OpenProject,
            this.Menu_File_OpenFile,
            this.toolStripSeparator5,
            this.Menu_File_CloseFile,
            this.Menu_File_CloseProject,
            this.toolStripSeparator8,
            this.Menu_File_Save,
            this.Menu_File_SaveAs,
            this.Menu_File_SaveAll,
            this.toolStripSeparator9,
            this.Menu_File_RecentFiles,
            this.Menu_File_RecentProjects,
            this.toolStripSeparator10,
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
            // 
            // Menu_File_OpenProject
            // 
            this.Menu_File_OpenProject.Name = "Menu_File_OpenProject";
            this.Menu_File_OpenProject.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_OpenProject.Text = "Open Project";
            // 
            // Menu_File_OpenFile
            // 
            this.Menu_File_OpenFile.Name = "Menu_File_OpenFile";
            this.Menu_File_OpenFile.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_OpenFile.Text = "Open File";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(152, 6);
            // 
            // Menu_File_CloseFile
            // 
            this.Menu_File_CloseFile.Name = "Menu_File_CloseFile";
            this.Menu_File_CloseFile.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_CloseFile.Text = "Close File";
            // 
            // Menu_File_CloseProject
            // 
            this.Menu_File_CloseProject.Name = "Menu_File_CloseProject";
            this.Menu_File_CloseProject.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_CloseProject.Text = "Close Project";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(152, 6);
            // 
            // Menu_File_Save
            // 
            this.Menu_File_Save.Name = "Menu_File_Save";
            this.Menu_File_Save.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_Save.Text = "Save";
            this.Menu_File_Save.Click += new System.EventHandler(this.Menu_File_Save_Click);
            // 
            // Menu_File_SaveAs
            // 
            this.Menu_File_SaveAs.Name = "Menu_File_SaveAs";
            this.Menu_File_SaveAs.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_SaveAs.Text = "Save File As...";
            // 
            // Menu_File_SaveAll
            // 
            this.Menu_File_SaveAll.Name = "Menu_File_SaveAll";
            this.Menu_File_SaveAll.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_SaveAll.Text = "Save All";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(152, 6);
            // 
            // Menu_File_RecentFiles
            // 
            this.Menu_File_RecentFiles.Name = "Menu_File_RecentFiles";
            this.Menu_File_RecentFiles.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_RecentFiles.Text = "Recent Files";
            // 
            // Menu_File_RecentProjects
            // 
            this.Menu_File_RecentProjects.Name = "Menu_File_RecentProjects";
            this.Menu_File_RecentProjects.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_RecentProjects.Text = "Recent Projects";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(152, 6);
            // 
            // Menu_File_Exit
            // 
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Size = new System.Drawing.Size(155, 22);
            this.Menu_File_Exit.Text = "Exit";
            // 
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Edit_Undo,
            this.Menu_Edit_Redo,
            this.toolStripSeparator2,
            this.Menu_Edit_Cut,
            this.Menu_Edit_Copy,
            this.Menu_Edit_Paste,
            this.Menu_Edit_Delete,
            this.toolStripSeparator3,
            this.Menu_Edit_SelectAll,
            this.toolStripSeparator4,
            this.Menu_Edit_QuickReplace,
            this.Menu_Edit_QuickFind});
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(39, 20);
            this.Menu_Edit.Text = "Edit";
            // 
            // Menu_Edit_Undo
            // 
            this.Menu_Edit_Undo.Name = "Menu_Edit_Undo";
            this.Menu_Edit_Undo.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_Undo.Text = "Undo";
            // 
            // Menu_Edit_Redo
            // 
            this.Menu_Edit_Redo.Name = "Menu_Edit_Redo";
            this.Menu_Edit_Redo.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_Redo.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // Menu_Edit_Cut
            // 
            this.Menu_Edit_Cut.Name = "Menu_Edit_Cut";
            this.Menu_Edit_Cut.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_Cut.Text = "Cut";
            // 
            // Menu_Edit_Copy
            // 
            this.Menu_Edit_Copy.Name = "Menu_Edit_Copy";
            this.Menu_Edit_Copy.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_Copy.Text = "Copy";
            // 
            // Menu_Edit_Paste
            // 
            this.Menu_Edit_Paste.Name = "Menu_Edit_Paste";
            this.Menu_Edit_Paste.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_Paste.Text = "Paste";
            // 
            // Menu_Edit_Delete
            // 
            this.Menu_Edit_Delete.Name = "Menu_Edit_Delete";
            this.Menu_Edit_Delete.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_Delete.Text = "Delete";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(146, 6);
            // 
            // Menu_Edit_SelectAll
            // 
            this.Menu_Edit_SelectAll.Name = "Menu_Edit_SelectAll";
            this.Menu_Edit_SelectAll.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_SelectAll.Text = "Select All";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(146, 6);
            // 
            // Menu_Edit_QuickReplace
            // 
            this.Menu_Edit_QuickReplace.Name = "Menu_Edit_QuickReplace";
            this.Menu_Edit_QuickReplace.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_QuickReplace.Text = "Quick Replace";
            // 
            // Menu_Edit_QuickFind
            // 
            this.Menu_Edit_QuickFind.Name = "Menu_Edit_QuickFind";
            this.Menu_Edit_QuickFind.Size = new System.Drawing.Size(149, 22);
            this.Menu_Edit_QuickFind.Text = "Quick Find";
            // 
            // Menu_View
            // 
            this.Menu_View.Name = "Menu_View";
            this.Menu_View.Size = new System.Drawing.Size(44, 20);
            this.Menu_View.Text = "View";
            // 
            // Menu_Project
            // 
            this.Menu_Project.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Project_AddClass,
            this.Menu_Project_AddNewItem,
            this.toolStripSeparator6,
            this.Menu_Project_Compile});
            this.Menu_Project.Name = "Menu_Project";
            this.Menu_Project.Size = new System.Drawing.Size(56, 20);
            this.Menu_Project.Text = "Project";
            // 
            // Menu_Project_AddClass
            // 
            this.Menu_Project_AddClass.Name = "Menu_Project_AddClass";
            this.Menu_Project_AddClass.Size = new System.Drawing.Size(152, 22);
            this.Menu_Project_AddClass.Text = "Add Class";
            // 
            // Menu_Project_AddNewItem
            // 
            this.Menu_Project_AddNewItem.Name = "Menu_Project_AddNewItem";
            this.Menu_Project_AddNewItem.Size = new System.Drawing.Size(152, 22);
            this.Menu_Project_AddNewItem.Text = "Add New Item";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // Menu_Project_Compile
            // 
            this.Menu_Project_Compile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Project_Compile_JustCompile,
            this.toolStripSeparator11,
            this.Menu_Project_Compile_Editor,
            this.Menu_Project_Compile_Game});
            this.Menu_Project_Compile.Name = "Menu_Project_Compile";
            this.Menu_Project_Compile.Size = new System.Drawing.Size(152, 22);
            this.Menu_Project_Compile.Text = "Compile";
            // 
            // Menu_Project_Compile_JustCompile
            // 
            this.Menu_Project_Compile_JustCompile.Name = "Menu_Project_Compile_JustCompile";
            this.Menu_Project_Compile_JustCompile.Size = new System.Drawing.Size(152, 22);
            this.Menu_Project_Compile_JustCompile.Text = "Just Compile";
            this.Menu_Project_Compile_JustCompile.Click += new System.EventHandler(this.Menu_Project_Compile_JustCompile_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(149, 6);
            // 
            // Menu_Project_Compile_Editor
            // 
            this.Menu_Project_Compile_Editor.Name = "Menu_Project_Compile_Editor";
            this.Menu_Project_Compile_Editor.Size = new System.Drawing.Size(152, 22);
            this.Menu_Project_Compile_Editor.Text = "with Editor";
            // 
            // Menu_Project_Compile_Game
            // 
            this.Menu_Project_Compile_Game.Name = "Menu_Project_Compile_Game";
            this.Menu_Project_Compile_Game.Size = new System.Drawing.Size(152, 22);
            this.Menu_Project_Compile_Game.Text = "with Game";
            // 
            // Menu_Tools
            // 
            this.Menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Tools_Settings,
            this.Menu_Tools_Options});
            this.Menu_Tools.Name = "Menu_Tools";
            this.Menu_Tools.Size = new System.Drawing.Size(48, 20);
            this.Menu_Tools.Text = "Tools";
            // 
            // Menu_Tools_Settings
            // 
            this.Menu_Tools_Settings.Name = "Menu_Tools_Settings";
            this.Menu_Tools_Settings.Size = new System.Drawing.Size(116, 22);
            this.Menu_Tools_Settings.Text = "Settings";
            // 
            // Menu_Tools_Options
            // 
            this.Menu_Tools_Options.Name = "Menu_Tools_Options";
            this.Menu_Tools_Options.Size = new System.Drawing.Size(116, 22);
            this.Menu_Tools_Options.Text = "Options";
            // 
            // Menu_Help
            // 
            this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Help_Documentation,
            this.Menu_Help_CheckForUpdates,
            this.toolStripSeparator7,
            this.Menu_Help_About});
            this.Menu_Help.Name = "Menu_Help";
            this.Menu_Help.Size = new System.Drawing.Size(44, 20);
            this.Menu_Help.Text = "Help";
            // 
            // Menu_Help_Documentation
            // 
            this.Menu_Help_Documentation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Help_Documentation_Search});
            this.Menu_Help_Documentation.Name = "Menu_Help_Documentation";
            this.Menu_Help_Documentation.Size = new System.Drawing.Size(173, 22);
            this.Menu_Help_Documentation.Text = "Documentation";
            // 
            // Menu_Help_Documentation_Search
            // 
            this.Menu_Help_Documentation_Search.Name = "Menu_Help_Documentation_Search";
            this.Menu_Help_Documentation_Search.Size = new System.Drawing.Size(100, 23);
            // 
            // Menu_Help_CheckForUpdates
            // 
            this.Menu_Help_CheckForUpdates.Name = "Menu_Help_CheckForUpdates";
            this.Menu_Help_CheckForUpdates.Size = new System.Drawing.Size(173, 22);
            this.Menu_Help_CheckForUpdates.Text = "Check For Updates";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(170, 6);
            // 
            // Menu_Help_About
            // 
            this.Menu_Help_About.Name = "Menu_Help_About";
            this.Menu_Help_About.Size = new System.Drawing.Size(173, 22);
            this.Menu_Help_About.Text = "About VisualUDK";
            // 
            // Menu_
            // 
            this.Menu_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1});
            this.Menu_.Location = new System.Drawing.Point(0, 24);
            this.Menu_.Name = "Menu_";
            this.Menu_.Size = new System.Drawing.Size(955, 25);
            this.Menu_.TabIndex = 3;
            this.Menu_.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProjectBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(955, 568);
            this.splitContainer1.SplitterDistance = 747;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.CodeEditor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ProjectStuff);
            this.splitContainer2.Size = new System.Drawing.Size(747, 568);
            this.splitContainer2.SplitterDistance = 445;
            this.splitContainer2.TabIndex = 5;
            // 
            // CodeEditor
            // 
            this.CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeEditor.Location = new System.Drawing.Point(0, 0);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.Size = new System.Drawing.Size(747, 445);
            this.CodeEditor.TabIndex = 1;
            this.CodeEditor.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.CodeEditor_CharAdded);
            this.CodeEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeEditor_KeyDown);
            // 
            // ProjectStuff
            // 
            this.ProjectStuff.Controls.Add(this.Window_Console);
            this.ProjectStuff.Controls.Add(this.Window_Errors);
            this.ProjectStuff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectStuff.Location = new System.Drawing.Point(0, 0);
            this.ProjectStuff.Name = "ProjectStuff";
            this.ProjectStuff.SelectedIndex = 0;
            this.ProjectStuff.Size = new System.Drawing.Size(747, 119);
            this.ProjectStuff.TabIndex = 0;
            // 
            // Window_Console
            // 
            this.Window_Console.Controls.Add(this.OutputConsole);
            this.Window_Console.Location = new System.Drawing.Point(4, 22);
            this.Window_Console.Name = "Window_Console";
            this.Window_Console.Padding = new System.Windows.Forms.Padding(3);
            this.Window_Console.Size = new System.Drawing.Size(739, 93);
            this.Window_Console.TabIndex = 0;
            this.Window_Console.Text = "Console";
            this.Window_Console.UseVisualStyleBackColor = true;
            // 
            // Window_Errors
            // 
            this.Window_Errors.Location = new System.Drawing.Point(4, 22);
            this.Window_Errors.Name = "Window_Errors";
            this.Window_Errors.Padding = new System.Windows.Forms.Padding(3);
            this.Window_Errors.Size = new System.Drawing.Size(739, 93);
            this.Window_Errors.TabIndex = 1;
            this.Window_Errors.Text = "Errors";
            this.Window_Errors.UseVisualStyleBackColor = true;
            // 
            // ProjectBrowser
            // 
            this.ProjectBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectBrowser.LabelEdit = true;
            this.ProjectBrowser.Location = new System.Drawing.Point(0, 0);
            this.ProjectBrowser.Name = "ProjectBrowser";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Node2";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Node1";
            this.ProjectBrowser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            this.ProjectBrowser.PathSeparator = "/";
            this.ProjectBrowser.Size = new System.Drawing.Size(204, 568);
            this.ProjectBrowser.TabIndex = 0;
            this.ProjectBrowser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProjectBrowser_MouseClick);
            this.ProjectBrowser.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProjectBrowser_MouseDoubleClick);
            // 
            // refresh
            // 
            this.refresh.Enabled = true;
            this.refresh.Interval = 1000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // OutputConsole
            // 
            this.OutputConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputConsole.Location = new System.Drawing.Point(3, 3);
            this.OutputConsole.Name = "OutputConsole";
            this.OutputConsole.Size = new System.Drawing.Size(733, 87);
            this.OutputConsole.TabIndex = 0;
            this.OutputConsole.Text = "";
            // 
            // ProjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Menu_);
            this.Controls.Add(this.Status_);
            this.Controls.Add(this.Strip_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Strip_;
            this.Name = "ProjectEditor";
            this.Text = "VisualUDK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectEditor_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Strip_.ResumeLayout(false);
            this.Strip_.PerformLayout();
            this.Menu_.ResumeLayout(false);
            this.Menu_.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).EndInit();
            this.ProjectStuff.ResumeLayout(false);
            this.Window_Console.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status_;
        private System.Windows.Forms.MenuStrip Strip_;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_NewProject;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_OpenProject;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit;
        private System.Windows.Forms.ToolStripMenuItem Menu_View;
        private System.Windows.Forms.ToolStripMenuItem Menu_Project;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help;
        private System.Windows.Forms.ToolStrip Menu_;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl ProjectStuff;
        private System.Windows.Forms.TabPage Window_Console;
        private System.Windows.Forms.TabPage Window_Errors;
        private System.Windows.Forms.TreeView ProjectBrowser;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Paste;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_QuickFind;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_QuickReplace;
        private System.Windows.Forms.ToolStripMenuItem Menu_Project_AddClass;
        private System.Windows.Forms.ToolStripMenuItem Menu_Project_AddNewItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem Menu_Project_Compile;
        private System.Windows.Forms.ToolStripMenuItem Menu_Project_Compile_Editor;
        private System.Windows.Forms.ToolStripMenuItem Menu_Project_Compile_Game;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools_Settings;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools_Options;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_Documentation;
        private System.Windows.Forms.ToolStripTextBox Menu_Help_Documentation_Search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_About;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_CheckForUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_CloseFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_CloseProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_SaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_RecentFiles;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_RecentProjects;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.Timer refresh;
        private ScintillaNET.Scintilla CodeEditor;
        private System.Windows.Forms.ToolStripMenuItem Menu_Project_Compile_JustCompile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.RichTextBox OutputConsole;
    }
}

