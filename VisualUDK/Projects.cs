using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisualUDK.UDKDataSetTableAdapters;
using System.IO;
using System.Windows.Forms;
using VisualUDK.Popups;
using VisualUDK.Popups.Wizards;

namespace VisualUDK
{
    class Projects
    {
        static UDKDataSet udkDataSet = new UDKDataSet();
        static QueriesTableAdapter query = new QueriesTableAdapter();
        static projectsTableAdapter project = new projectsTableAdapter();

        public static Boolean checkEnginePath()
        {
            String enginePath = Settings.getEnginePath();

            if (File.Exists(enginePath + "Engine/Config/BaseEngine.ini")) return true;
            else return false;
        }

        public static void newProject()
        {
            if(Settings.checkEnginePath()) {

                NewProject np = new NewProject();
                np.Show();
            }
            else
            {
                MessageBox.Show("Engine Path has not been set correctly");
                Options op = new Options();
                op.Show();
            }
        }

        /// <summary>
        /// Open Project will open a window that scans for "mods" that are selectable
        /// </summary>
        public static void openProject()
        {
            if (Settings.checkEnginePath())
            {
                OpenProject op = new OpenProject();
                op.Show();
            }
            else
            {
                MessageBox.Show("Engine Path has not been set correctly");
                Options op = new Options();
                op.Show();
            }
        }
    }
}
