using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using EmployeeManagementApp.Loader;

namespace EmployeeManagementApp
{
    class Program
    {
       public  static string pathdisk = "D:/Swabhav/DataFile.txt";
        static void Main(string[] args)
        {
            try
            {
                CSVLoader csv = new CSVLoader();
                csv.Load(pathdisk);
                RecordAnalyzer analyzer = new RecordAnalyzer();
                Dictionary<Employee, Employee> employeelist = csv.GetEmployeeList();
                Console.WriteLine(analyzer.MaximumSalariedEmployee(employeelist).Salary);
                Dictionary<string, int> departments,designations;
                departments = analyzer.DepartmentWiseCount(employeelist);
                foreach(KeyValuePair<string,int>department in departments)
                {
                    Console.WriteLine(department.Key +" "+department.Value);
                }
                designations = analyzer.DesignationWiseCount(employeelist);
                foreach (KeyValuePair<string, int> designation in designations)
                {
                    Console.WriteLine(designation.Key + " " + designation.Value);
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            }
    }
}
