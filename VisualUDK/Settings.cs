using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualUDK.UDKDataSetTableAdapters;
using System.Data.SqlClient;
using System.IO;

namespace VisualUDK
{
    class Settings
    {
        static UDKDataSet udkDataSet = new UDKDataSet();
        static QueriesTableAdapter query = new QueriesTableAdapter();
        static optionsTableAdapter options = new optionsTableAdapter();

        public static Boolean updateEnginePath(String path)
        {
            try
            {
                query.UpdateEnginePath(path); // attempt query
                if (FileMan.getEnginePath() == path)
                    return true;
                else return false;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Could not update engine path at this time, please try again");
                return false;
            }
        }
    }
}
