using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisualUDK.UDKDataSetTableAdapters;
using System.IO;
using System.Windows.Forms;
using VisualUDK.Popups;
using VisualUDK.Popups.Wizards;
using VisualUDK.Utilities;

namespace VisualUDK
{
    class Projects
    {
        static UDKDataSet udkDataSet = new UDKDataSet();
        static QueriesTableAdapter query = new QueriesTableAdapter();
        static projectsTableAdapter project = new projectsTableAdapter();

        

        public static void newProject()
        {
            if(FileMan.checkEnginePath()) {

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
        /// Inserts a new Project into the database, returns new ID i think..
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static int createNewProject(String name, String path)
        {
            return query.CreateNewProject(name, path);
        }

        /// <summary>
        /// Open Project will open a window that scans for "mods" that are selectable
        /// </summary>
        public static void openProject()
        {
            if (FileMan.checkEnginePath())
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
