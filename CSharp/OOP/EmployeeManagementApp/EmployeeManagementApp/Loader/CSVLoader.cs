using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EmployeeManagementApp.Loader
{

    public class CSVLoader 
    {
       
        private string[] lines;

     public CSVLoader(string path)
        {
            lines = File.ReadAllLines(path);
        }
        public string[] Lines
        {
            get
            {
                return lines;
            }
        }
       

    }
}
