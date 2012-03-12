using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VisualUDK.Popups.Wizards
{
    public partial class NewFile : Form
    {

        String basePath;

        public NewFile(String path)
        {
            basePath = path;
            InitializeComponent();
        }

        private void NewFile_Load(object sender, EventArgs e)
        {
            fileName.Focus();
        }
        
        private void CreateFile_Click(object sender, EventArgs e)
        {
            String file = basePath + "\\" + fileName.Text.ToString().Trim()+".uc";
            using (StreamWriter sw = File.CreateText(file))
            {
                sw.WriteLine("class " + fileName.Text.ToString().Trim() + ";");
                sw.WriteLine(" ");

                this.Close();
            }
        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateFile.PerformClick();
            }
        }
    }
}
