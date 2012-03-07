using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualUDK.Popups
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            txt_EnginePath.Text = Settings.getEnginePath();
        }

        private void But_EngineBrowse_Click(object sender, EventArgs e)
        {

        }

        private void txt_EnginePath_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
