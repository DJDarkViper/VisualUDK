using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualUDK.Popups;
using VisualUDK.Popups.Wizards;
using VisualUDK.UDKDataSetTableAdapters;

namespace VisualUDK
{
    public partial class Splash : Form
    {
        
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void But_NewProject_Click(object sender, EventArgs e)
        {
            Projects.newProject();
        }

        private void But_OpenProject_Click(object sender, EventArgs e)
        {

        }

        private void Menu_File_NewProject_Click(object sender, EventArgs e)
        {
            Projects.newProject();
        }

        private void Menu_File_OpenProject_Click(object sender, EventArgs e)
        {

        }

        private void Menu_File_RecentProjects_Click(object sender, EventArgs e)
        {

        }

        private void Menu_File_Exit_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Help_About_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Help_CheckForUpdates_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Tools_Options_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.Show();
        }

        
    }
}
