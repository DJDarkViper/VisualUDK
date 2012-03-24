using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace VisualUDK.Popups {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Donate_Click(object sender, EventArgs e) {
            try {
                Process.Start("http://www.blackjaguarstudios.com/software/visualudk/donate.php");
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex);
            }
 
            this.Close();
        }
    }
}
