using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualUDK.Utilities
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            progressBar.Value = 0;
        }

        public void increment(int Amount)
        {
            progressBar.Value += Amount;
        }

        public void set(int Amount)
        {
            progressBar.Value = Amount;
        }

        public void finish()
        {
            progressBar.Value = progressBar.Maximum;
        }

        public Boolean isDone()
        {
            if (progressBar.Value == progressBar.Maximum) return true;
            else return false;
        }
    }
}
