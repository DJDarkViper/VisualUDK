using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace VisualUDK
{
    class DB
    {
        private String connection = Properties.Settings.Default.UDKConnectionString;
        private SqlCeConnection con;
        private SqlCeCommand com;

        private String mode             = null;
        private List<String> Columns    = null;
        private List<String> Where      = null;
        private String From             = null;
        private String Orderby          = null;

        private String command          = null;

        /// <summary>
        /// Chainable Database Driver for Microsoft SqlCe
        /// </summary>
        public DB()
        {
            Columns = new List<String>();
            Where = new List<String>();
        }


        public DB select(String[] items)
        {
            Columns.Clear();
            foreach (String item in items) Columns.Add(item.Trim());

            mode = "select";

            return build();
        }

        public DB select(String items)
        {
            Columns.Clear();
            String[] newitems = items.Split(new char[] {','});
            foreach (String item in newitems) Columns.Add(item.Trim());

            mode = "select";

            return build();
        }

        public DB from(String table)
        {
            From = table.Trim();
            
            return build();
        }

        public DB where(String column, String data, String op = "=")
        {
            Where.Add(column.Trim()+" "+op+" '"+data.Trim()+"'");
            
            return build();
        }




        /// <summary>
        /// Builds the Query
        /// </summary>
        /// <returns></returns>
        public DB build()
        {
            List<String> c = new List<String>();
            if (mode != null)
            {

                switch (mode)
                {
                    case "select":

                        c.Add("SELECT");

                        if (Columns.Count > 0) { c.Add(String.Join(",", Columns.ToArray())); }
                        if (From != null) { c.Add("FROM " + From); }
                        if (Where.Count > 0) { c.Add("WHERE " + String.Join(" AND ", Where.ToArray())); }

                        break;
                    case "update":

                        c.Add("UPDATE");
                        

                        break;
                    case "insert":

                        c.Add("INSERT");

                        break;
                }


                command = String.Join(" ", c.ToArray());

            }

            return this;
        }


        public String getCommand()
        {
            return command;
        }
    }
}
