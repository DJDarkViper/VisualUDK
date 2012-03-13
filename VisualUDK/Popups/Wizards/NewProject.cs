using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using VisualUDK.Utilities;
using System.IO;
using System.Security.Cryptography;

namespace VisualUDK.Popups.Wizards
{
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void but_CreateProject_Click(object sender, EventArgs e)
        {
            but_CreateProject.Enabled = false;
            but_CreateProject.Text = "Please Wait..";

            Progress p = new Progress();
            p.Show();
            p.set(10);

            if (ValidateNewProject())
            {
                
                p.set(20);

                Project np = new Project();
                np.setName(projectName.Text);
                np.setPath(systemName.Text);

                if (np.save())
                {
                    p.set(30);

                    Directory.CreateDirectory(FileMan.getSrc() + systemName.Text.ToString().Trim());
                    Directory.CreateDirectory(FileMan.getSrc() + systemName.Text.ToString().Trim() + "/Classes");

                    p.set(50);

                    if (isAttemptToConfigure.CheckState.ToString() == "Checked")
                    {

                        String lines = "";

                        using (StreamReader sr = File.OpenText(FileMan.getEngineIni()))
                        {
                            Boolean grab = false;
                            String l = "";
                            
                            while ((l = sr.ReadLine()) != null)
                            {
                                

                                if (l == "[UnrealEd.EditorEngine]")
                                {
                                    grab = true;
                                }

                                if (grab == true)
                                {
                                    Match match = Regex.Match(l, "(\\+EditPackages)");

                                    if (match.Success)
                                    {
                                        //parsed += l+"\n";
                                    }
                                }

                                if (grab == true && l == "")
                                {
                                    //parsed += "+EditPackages=" + systemName.Text.ToString().Trim()+"\n\n";
                                    lines += "+EditPackages=" + systemName.Text.ToString().Trim() + "\n\n";

                                    grab = false;
                                }
                                else
                                {
                                    lines += l + "\n";
                                }

                                
                            }


                            sr.Close();

                            File.Copy(FileMan.getEngineIni(), FileMan.getEngineIni() + ".bak."+DateTime.Now.ToString("M-d-yyyy")+"_"+Crypto.getRandomHash());
                            File.WriteAllText(FileMan.getEngineIni(), lines);

                        }
                        
                        
                        
                        p.increment(20);


                    }

                    if (isCreateClass.CheckState.ToString() == "Checked")
                    {
                        String filePath = FileMan.getSrc() + systemName.Text.ToString().Trim() + "/Classes/" + className.Text.ToString().Trim() + ".uc";
                        using (StreamWriter sw = File.CreateText(filePath))
                        {
                            sw.WriteLine("class " + className.Text.ToString().Trim() + ((classInherits.Text.ToString().Trim() != "") ? " extends " + classInherits.Text.ToString().Trim() : "") + ";");
                            sw.WriteLine(" ");
                        }


                        p.increment(20);
                        
                    }

                    p.finish();
                    p.Close();
                    this.Close();
                 
                }
                else
                {
                    MessageBox.Show("Could not create project correctly at this time...");
                    p.finish();
                    p.Close();
                }
                 
            }
            else
            {
                p.finish();
                p.Close();
                but_CreateProject.Text = "Create Project";
                but_CreateProject.Enabled = true;
            }

        }

        private void projectName_TextChanged(object sender, EventArgs e)
        {
            systemName.Text = parseSystemName(projectName.Text.ToString());
        }

        private String parseSystemName(String txt)
        {
            txt = new Regex("([^a-zA-Z0-9]*)").Replace(txt, "");

            return txt;
        }

        private Boolean ValidateNewProject()
        {
            if (projectName.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please enter a project name");
                return false;
            }
            if (systemName.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please enter a system name");
                return false;
            }

            if (isCreateClass.CheckState.ToString() == "Checked" && className.Text.ToString().Trim() == "")
            {
                MessageBox.Show("When you have auto create class checked, you must also supply a class name!");
                return false;
            }

            return true;
        }
    }
}
