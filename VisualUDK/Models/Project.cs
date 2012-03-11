using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using VisualUDK.UDKDataSetTableAdapters;

namespace VisualUDK.Models
{
    class Project
    {
        private int ID;
        private String Name;
        private String SystemPath;

        public void setID(int ID) { this.ID = ID; }
        public void setName(String Name) { this.Name = Name.ToString().Trim(); }
        public void setPath(String Path) { this.SystemPath = Path.ToString().Trim(); }

        public int getID() { return this.ID; }
        public String getName() { return this.Name; }
        public String getPath() { return this.SystemPath; }


        public void fetchByID(int id)
        {
            
        }

        public void fetchByName(String name)
        {

        }


        /** Static Getters **/
        public static int TotalProjects()
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
    }
}
