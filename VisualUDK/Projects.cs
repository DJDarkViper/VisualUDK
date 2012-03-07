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

        public static Boolean newProject()
        {
            String enginePath = Settings.getEnginePath();

            if (File.Exists(enginePath + "Engine/Config/BaseEngine.ini"))
            {
                NewProject np = new NewProject();
                np.Show();

                return true;
            }
            else
            {
                MessageBox.Show("Engine Path has not been set correctly");
                Options op = new Options();
                op.Show();

                return false;
            }
        }
    }
}
