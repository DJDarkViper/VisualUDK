using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisualUDK.UDKDataSetTableAdapters;

namespace VisualUDK
{
    class Settings
    {
        static QueriesTableAdapter query = new QueriesTableAdapter();


        public static String getEnginePath()
        {
            return query.FetchEnginePath();
        }
    }
}
