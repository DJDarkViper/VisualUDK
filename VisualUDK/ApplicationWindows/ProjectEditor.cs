using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using VisualUDK.Popups.Wizards;

namespace VisualUDK
{
    public partial class ProjectEditor : Form
    {

        Project project;
        String Src;


        // ActiveTreeNode
        TreeNode activeTreeNode;

        public ProjectEditor(int id)
        {
            project = new Project(id);
            Src = FileMan.getSrc() + project.getPath();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "VisualUDK - " + project.getName();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);

            PopulateProjectBrowser();
            
            
        }

        private void ProjectEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ProjectBrowser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                activeTreeNode = ProjectBrowser.GetNodeAt(e.X, e.Y);
                //MessageBox.Show(selectedNode.Text);
                ContextMenu treeMenu = new ContextMenu();
                
                MenuItem newFile = new MenuItem();
                newFile.Text = "&New Class";
                newFile.Click += new EventHandler(newFile_Click);
                
                MenuItem openFile = new MenuItem();
                openFile.Text = "&Open Class";
                openFile.Click += new EventHandler(openFile_Click);
                
                MenuItem refreshFiles = new MenuItem();
                refreshFiles.Text = "&Refresh";
                refreshFiles.Click += new EventHandler(refreshFiles_Click);


                treeMenu.MenuItems.Add(newFile);
                treeMenu.MenuItems.Add(openFile);
                treeMenu.MenuItems.Add("-");
                treeMenu.MenuItems.Add(refreshFiles);


                treeMenu.Show(ProjectBrowser, new Point(e.X, e.Y));
                
            }
        }

        void refreshFiles_Click(object sender, EventArgs e)
        {
            PopulateProjectBrowser();
        }

        void openFile_Click(object sender, EventArgs e)
        {
            
        }

        void newFile_Click(object sender, EventArgs e)
        {
            NewFile nf = new NewFile(Src);
            nf.ShowDialog();

            PopulateProjectBrowser();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            //PopulateProjectBrowser();
        }



        private void PopulateProjectBrowser()
        {
            ProjectBrowser.Nodes.Clear();
            ProjectBrowser.Nodes.Add( new TreeNode( project.getName() ) );
            foreach (String dir in Directory.GetDirectories(Src))
            {
                Trace.WriteLine("Dir: " + dir);

                List<TreeNode> files = new List<TreeNode>();

                Trace.Indent();
                foreach (String file in Directory.GetFiles(dir))
                {
                    Trace.WriteLine(file);
                    files.Add(new TreeNode(Path.GetFileName(file)));
                }
                Trace.Unindent();

                ProjectBrowser.Nodes.Add(new TreeNode(Path.GetDirectoryName(dir), files.ToArray()));
            }

            ProjectBrowser.ExpandAll();
        }
    }
}
