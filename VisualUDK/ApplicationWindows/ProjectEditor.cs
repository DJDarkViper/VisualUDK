using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualUDK
{
    public partial class ProjectEditor : Form
    {

        Project project;

        public ProjectEditor(int id)
        {
            project = new Project(id);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "VisualUDK - " + project.getName();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void ProjectEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
