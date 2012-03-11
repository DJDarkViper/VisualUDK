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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

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


        public static List<String[]> getProjects()
        {
            List<String[]> items = new List<String[]>();
            using (SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.UDKConnectionString))
            {
                con.Open();
                using(SqlCeCommand com = new SqlCeCommand("SELECT id,name,path FROM projects", con))
                {
                    
                    SqlCeDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        items.Add(
                            new String[3] { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2) }
                        );
                    }

                    return items;
                }
            }
            
            
        }
    }
}
