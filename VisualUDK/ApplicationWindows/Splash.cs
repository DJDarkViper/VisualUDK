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
            SplashBrowser.Url = new Uri("https://bitbucket.org/DJDarkViper/visualudk/wiki/Home");

            ProjectList.View = View.Details;
            ProjectList.FullRowSelect = true;
            ProjectList.Sorting = SortOrder.Ascending;

            ProjectList.Columns.Add("Recent Projects", -2, HorizontalAlignment.Left);

            Projects.getProjects();
            //List<String[]> allProjects = new List<String[]>( Projects.getProjects() );

            //MessageBox.Show(allProjects.ToString());

            /*
            projects.ForEach(delegate(String[] project)
            {
                MessageBox.Show("Test: ");
                ProjectList.Items.AddRange(new ListViewItem[] { new ListViewItem("Stuff", 0) });
            });
             */

            /*
            ListViewItem item1 = new ListViewItem("Sparticus Landing", 0);
            ProjectList.Items.AddRange(new ListViewItem[] { item1 });

            ListViewItem item2 = new ListViewItem("Sparticus Landing", 0);
            ProjectList.Items.AddRange(new ListViewItem[] { item2 });
            */
        }

        private void But_NewProject_Click(object sender, EventArgs e)
        {
            Projects.newProject();
        }

        private void But_OpenProject_Click(object sender, EventArgs e)
        {
            Projects.openProject();
        }

        private void Menu_File_NewProject_Click(object sender, EventArgs e)
        {
            Projects.newProject();
        }

        private void Menu_File_OpenProject_Click(object sender, EventArgs e)
        {
            Projects.openProject();
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
