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
    class Project
    {
        private int ID              = -1;
        private String Name         = null;
        private String SystemPath   = null;

        public Project() {}

        public Project(int id = -1)
        {
            if (id != -1) fetchByID(id);
        }

        public Project(String name = "")
        {
            if (name != "") fetchByName(name);
        }

        public void setID(int ID) { this.ID = ID; }
        public void setName(String Name) { this.Name = Name.ToString().Trim(); }
        public void setPath(String Path) { this.SystemPath = Path.ToString().Trim(); }

        public int getID() { return this.ID; }
        public String getName() { return this.Name; }
        public String getPath() { return this.SystemPath; }

        private void fetch(String command)
        {
            using (SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.UDKConnectionString))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand(command, con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();
                    reader.Read();
                    setID(reader.GetInt32(0));
                    setName(reader.GetString(1));
                    setPath(reader.GetString(2));
                }
            }
        }

        public void fetchByID(int id)
        { fetch( "SELECT id,name,path FROM projects WHERE ( id = '"+id+"' )" ); }

        public void fetchByName(String name)
        { fetch( "SELECT id,name,path FROM projects WHERE ( name = '"+name+"' )" ); }

        public void open()
        {

        }

        public Boolean save()
        {
            String command = "";
            if (getID() == -1)
            {
                // new
                command = "INSERT INTO projects (name, path) VALUES ('"+getName()+"','"+getPath()+"')";
            }
            else
            {
                // update
                command = "UPDATE projects SET name='" + getName() + "', path='" + getPath() + "' WHERE id='" + getID() + "'";
            }
            
            using (SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.UDKConnectionString))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand(command, con))
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }


        /** Static Getters **/
        public static int totalProjects()
        {
            int total = 0;
            using (SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.UDKConnectionString))
            {
                con.Open();
                using(SqlCeCommand com = new SqlCeCommand("SELECT COUNT(*) FROM projects", con))
                {
                    
                    SqlCeDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        total = reader.GetInt32(0);
                    }

                }
                con.Close();
                return total;
            }
        }

        public static List<String[]> getProjects()
        {
            List<String[]> items = new List<String[]>();
            using (SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.UDKConnectionString))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT id,name,path FROM projects", con))
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

        public static void getRecentProjects(int limit = 0)
        {
        }

        public static void openNewProjectWizard()
        {
            if (FileMan.checkEnginePath())
            {

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

        public static void openOpenProjectWizard()
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
