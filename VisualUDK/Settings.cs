using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisualUDK.UDKDataSetTableAdapters;
using System.Data.SqlClient;

namespace VisualUDK
{
    class Settings
    {
        static QueriesTableAdapter query = new QueriesTableAdapter();
        static optionsTableAdapter options = new optionsTableAdapter();

        public static String getEnginePath()
        {
            return query.FetchEnginePath();
        }

        public static Boolean updateEnginePath(String path)
        {
            SqlConnection con = new SqlConnection("Data Source=|DataDirectory|\\UDK.sdf");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE options SET value='"+path+"' WHERE setting='enginePath'";
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
    }
}
