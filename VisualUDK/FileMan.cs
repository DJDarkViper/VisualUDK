using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using VisualUDK.UDKDataSetTableAdapters;

namespace VisualUDK
{
    class FileMan
    {
        static UDKDataSet udkDataSet = new UDKDataSet();
        static QueriesTableAdapter query = new QueriesTableAdapter();


        public static Boolean checkEnginePath()
        {
            if (File.Exists(FileMan.getBase() + "Engine/Config/BaseEngine.ini")) return true;
            else return false;
        }

        public static String getEngineIni()
        {
            return FileMan.getGame()+"Config/DefaultEngine.ini";
        }

        public static String getCompiler() {
            return FileMan.getBase()+"Binaries/Win32/UDK.com";
        }

        public static String getEditor() {
            return FileMan.getBase() + "Binaries/UDKLift.exe";
        }

        public static String getGameExe() {
            return FileMan.getBase() + "Binaries/Win32/UDK.exe";
        }

        /*
         * Paths
         */

        public static String getBase()
        {
            String enginePath = FileMan.getEnginePath();
            if (File.Exists(enginePath + "Engine/Config/BaseEngine.ini")) return enginePath;
            else if (File.Exists(enginePath + "/Engine/Config/BaseEngine.ini")) return enginePath + "/";
            else return "";
        }

        public static String getEngine()
        {
            return getBase() + "Engine/";
        }

        public static String getGame()
        {
            return getBase() + "UDKGame/";
        }

        public static String getSrc()
        {
            return getBase() + "Development/src/";
        }

        public static String getEnginePath()
        {
            return query.FetchEnginePath();
        }

    }
}
