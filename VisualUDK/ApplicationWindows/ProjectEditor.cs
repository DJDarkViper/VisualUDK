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
using System.Reflection;
using VisualUDK.Popups.Wizards;

namespace VisualUDK
{
    public partial class ProjectEditor : Form
    {

        Project project;
        String Src;
        ImageList images;
        UDKFile activefile;

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

            images = new ImageList();

            images.Images.Add(Properties.Resources.HP_FolderGrey);
            images.Images.Add(Properties.Resources.HP_Folder);
            images.Images.Add(Properties.Resources.HP_FolderDocuments);
            images.Images.Add(Properties.Resources.unreal_logo);

            ProjectBrowser.ImageList = images;
            

            PopulateProjectBrowser();
            
            
        }

        private void ProjectEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ProjectBrowser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                activeTreeNode = ProjectBrowser.GetNodeAt(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
                activeTreeNode = ProjectBrowser.GetNodeAt(e.X, e.Y);
                //MessageBox.Show(selectedNode.Text);
                ContextMenu treeMenu = new ContextMenu();
                
                MenuItem newFile = new MenuItem();
                newFile.Text = "&New Class";
                newFile.Click += new EventHandler(newFile_Click);
                
                MenuItem openFile = new MenuItem();
                openFile.Text = "&Open File";
                openFile.Click += new EventHandler(openFile_Click);

                MenuItem deleteFile = new MenuItem();
                deleteFile.Text = "&Delete File";
                deleteFile.Click += new EventHandler(deleteFile_Click);
                
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

        void deleteFile_Click(object sender, EventArgs e)
        {
            
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
            NewFile nf = new NewFile(Src+"\\Classes"); // hardcoded because.. well.. in this situation, why not?
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
            ProjectBrowser.Nodes.Add( new TreeNode( project.getName(), 3, 3 ) );
            foreach (String dir in Directory.GetDirectories(Src))
            {
                Trace.WriteLine("Dir: " + dir);

                List<TreeNode> files = new List<TreeNode>();

                Trace.Indent();
                foreach (String file in Directory.GetFiles(dir))
                {
                    Trace.WriteLine(file);

                    files.Add(new TreeNode(Path.GetFileName(file), 0, 1));
                }
                Trace.Unindent();

                ProjectBrowser.Nodes.Add(new TreeNode(Path.GetFileName(dir), 2, 2, files.ToArray()));
            }

            ProjectBrowser.ExpandAll();
        }

        private void ProjectBrowser_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (File.Exists(Src + "\\Classes\\" + activeTreeNode.Text)) {

                activefile = new UDKFile(Src + "\\Classes\\" + activeTreeNode.Text);

                CodeEditor.Lines = activefile.ReadContents();

            }
            
        }
    }
}
