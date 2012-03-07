using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisualUDK.UDKDataSetTableAdapters;
using System.Data.SqlClient;
using System.Data;

namespace VisualUDK
{
    class Settings
    {
        static UDKDataSet udkDataSet = new UDKDataSet();
        static QueriesTableAdapter query = new QueriesTableAdapter();
        static optionsTableAdapter options = new optionsTableAdapter();

        public static String getEnginePath()
        {
            return query.FetchEnginePath();
        }

        public static Boolean updateEnginePath(String path)
        {
            query.UpdateEnginePath(path);
            return true;
        }
    }
}
