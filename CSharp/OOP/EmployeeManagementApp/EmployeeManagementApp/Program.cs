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
        public static string webpath = "https://swabhav-tech.firebaseapp.com/emp.txt";
        static void Main(string[] args)
        {
            try
            {
             RecordAnalyzer analyzer = new RecordAnalyzer (new DataParser (new CSVLoader(pathdisk)));
                display(analyzer.MaximumSalariedEmployee());
                display1(analyzer.DepartmentWiseCount());
                display1(analyzer.DesignationWiseCount());
                RecordAnalyzer analyzer1 = new RecordAnalyzer(new DataParser(new WebLoader(webpath)));
                display(analyzer1.MaximumSalariedEmployee());
                display1(analyzer1.DepartmentWiseCount());
                display1(analyzer1.DesignationWiseCount());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
       static void display(Employee employee)
        {
            Console.WriteLine("employee id = "+employee.EmployeeId);
            Console.WriteLine("employee name = "+employee.Name);
            Console.WriteLine("employee designation = "+employee.EmployeeDesignation);
            Console.WriteLine("employee salary = "+employee.Salary);
        }
        static void display1(Dictionary<string,int> displays)
        {

            foreach (KeyValuePair<string, int> display in displays)
            {
                Console.WriteLine(display.Key + " " + display.Value);
            }


        }

    }
}
