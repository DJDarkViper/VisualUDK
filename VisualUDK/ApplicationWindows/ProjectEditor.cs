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

namespace VisualUDK
{
    public partial class ProjectEditor : Form
    {

        Project project;
        String Src;


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

            
            
            foreach (String dir in Directory.GetDirectories(Src))
            {
                Trace.WriteLine("Dir: " + dir);

                List<TreeNode> files = new List<TreeNode>();

                Trace.Indent();
                foreach (String file in Directory.GetFiles(dir))
                {
                    Trace.WriteLine(file);
                    files.Add(new TreeNode(file));
                }
                Trace.Unindent();

                ProjectBrowser.Nodes.Add( new TreeNode(dir, files.ToArray()) );
            }

            
            

        }

        private void ProjectEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ProjectBrowser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode selectedNode = ProjectBrowser.GetNodeAt(e.X, e.Y);
                MessageBox.Show(selectedNode.Text);
            }
        }
    }
}
