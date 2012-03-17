using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace VisualUDK {
    class UDKFile {

        public String path;

        public UDKFile() {}

        public UDKFile(String file) {
            setFile(file);
        }

        public Boolean setFile(String file) {
            if (File.Exists(file)) {
                this.path = file;
                return true;
            } else return false;
        }

        public String[] ReadContents() {

            List<String> lines = new List<String>();
            using (StreamReader sr = File.OpenText(this.path)) {
                String l = "";
                while((l = sr.ReadLine()) != null) {
                    lines.Add(l);
                }
            }

            return lines.ToArray();

        }

        public Boolean Save(String text) {
            try {
                StreamWriter sw = new StreamWriter(this.path);
                sw.Write(text);
                sw.Close();
                return true;
            } catch (Exception e) {
                Trace.WriteLine(e);
                return false;
            }
        }


    }
}
