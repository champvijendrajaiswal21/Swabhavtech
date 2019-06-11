using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EmployeeManagementApp.Loader
{

    public class CSVLoader
    {
        private DataParser _parser;

     public   CSVLoader()
        {

        _parser = new DataParser();
    }
        private string[] lines;

        public void Load(string path)
        {
            lines = File.ReadAllLines(path);


        }
        public Dictionary<Employee, Employee> GetEmployeeList()
        {
            return _parser.GenerateEmployeeList(lines);
        }
    }
}
