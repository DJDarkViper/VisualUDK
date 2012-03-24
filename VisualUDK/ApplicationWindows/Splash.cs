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
            this.Text = "VisualUDK " + Settings.getVersionString();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashBrowser.Url = new Uri("http://www.blackjaguarstudios.com/software/visualudk/");

            PopulateRecentList();
            
        }

        private void PopulateRecentList()
        {
            ProjectList.Clear();

            ProjectList.View = View.Details;
            ProjectList.FullRowSelect = true;
            ProjectList.Sorting = SortOrder.Ascending;

            ProjectList.Columns.Add("Recent Projects", -2, HorizontalAlignment.Left);

            List<String[]> projects = new List<String[]>(Project.getProjects());

            foreach (String[] project in projects)
            {
                ProjectList.Items.AddRange(new ListViewItem[] { new ListViewItem(project[1], 0) });
            }
        }

        private void But_NewProject_Click(object sender, EventArgs e)
        {
            Project.openNewProjectWizard();
            PopulateRecentList();
        }

        private void But_OpenProject_Click(object sender, EventArgs e)
        {
            Project.openOpenProjectWizard();
        }

        private void Menu_File_NewProject_Click(object sender, EventArgs e)
        {
            Project.openNewProjectWizard();
            PopulateRecentList();
        }

        private void Menu_File_OpenProject_Click(object sender, EventArgs e)
        {
            Project.openOpenProjectWizard();
        }

        private void Menu_File_RecentProjects_Click(object sender, EventArgs e)
        {

        }

        private void Menu_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Help_About_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void Menu_Help_CheckForUpdates_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Tools_Options_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.Show();
        }

        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ProjectList_DoubleClick(object sender, EventArgs e)
        {
            String item = ProjectList.SelectedItems[0].Text;
            Project project = new Project(item);
            if (project.open())
            {
                //this.Hide(); // figure this one out later
            }
            else
            {
                MessageBox.Show( "Could not open project" );
            }
            
        }
 
    }
}
