using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    /// <summary>
    /// this is a class for basic functionalities in the program
    /// </summary>
    public class Functionalities
    {
        private string file;
        public Functionalities(string file)
        {
            this.file = file;
        }

        /// <summary>
        /// this method loads a program to the command line
        /// uses a dialog box to select a program file
        /// </summary>
        /// <returns>returns file contents to the command line</returns>
        public string LoadProgram()
        {
            
            OpenFileDialog openFileDialog = new();

           
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                StreamReader reader = new(openFileDialog.FileName);
                file = reader.ReadToEnd();
                reader.Close();
            }
            return file;
        }

        public string SaveProgram()
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Save My Program"
            };

            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                string myProgramName = saveFileDialog.FileName;     ///writing to the pg
                TextWriter writer = new StreamWriter(myProgramName);
                writer.WriteLine(file);
                MessageBox.Show("Program has been saved!");
                writer.Close();
            }
            return file;
            
        }

        public string File
        {
            get { return file; }   
            set { file = value; }
        }
       
    }
}
