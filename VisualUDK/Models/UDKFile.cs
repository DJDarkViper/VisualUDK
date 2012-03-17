using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualUDK {
    class UDKFile {

        public String path;

        public UDKFile() {}

        public UDKFile(String file) {
            if (setFile(file)) {
                Open(this.path);
            }

        }

        public Boolean setFile(String file) {
            if (File.Exists(file)) {
                this.path = file;
                return true;
            } else return false;
        }

        public void Open(String file) {

        }


    }
}
