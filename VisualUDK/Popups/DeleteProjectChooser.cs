using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualUDK.Popups {
    public partial class DeleteProjectChooser : Form {

        public String name;
        public String delType;

        public DeleteProjectChooser(String projectName) {
            InitializeComponent();
            name = projectName;
            ProjectText.Text = "Really delete '" + name + "'?";
        }

        private void DeleteProjectChooser_Load(object sender, EventArgs e) {

        }

        private void DeleteReference_Click(object sender, EventArgs e) {
            delType = "ref";
            this.Close();
        }

        private void DeleteFromSystem_Click(object sender, EventArgs e) {
            delType = "sys";
            this.Close();
        }
    }
}
