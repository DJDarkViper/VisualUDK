using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VisualUDK.Popups.Wizards
{
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void but_CreateProject_Click(object sender, EventArgs e)
        {
            if (ValidateNewProject())
            {

            }
        }

        private void projectName_TextChanged(object sender, EventArgs e)
        {
            systemName.Text = parseSystemName(projectName.Text.ToString());
        }

        private String parseSystemName(String txt)
        {
            txt = new Regex("([^a-zA-Z0-9]*)").Replace(txt, "");

            return txt;
        }

        private Boolean ValidateNewProject()
        {
            if (projectName.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please enter a project name");
                return false;
            }
            if (systemName.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please enter a system name");
                return false;
            }

            if (isCreateClass.CheckState.ToString() == "Checked" && className.Text.ToString().Trim() == "")
            {
                MessageBox.Show("When you have auto create class checked, you must also supply a class name!");
                return false;
            }

            return true;
        }
    }
}
