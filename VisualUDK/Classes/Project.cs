using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualUDK.Classes
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

    }
}
