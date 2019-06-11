using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementApp
{
    class DataParser
    {
        private Dictionary<Employee, Employee> _employeelistdictionary =
             new Dictionary<Employee, Employee>();
        private Employee _employee;

        public Dictionary<Employee, Employee> GenerateEmployeeList(string[] employee)
        {
           

            foreach (string line in employee)
            {
                //try block
                try
                {
                    string[] dataList = line.Split(',');
                    _employee = new Employee(dataList[0], dataList[1], dataList[2],
                        dataList[3], dataList[4], dataList[5], dataList[6], dataList[7]);
                   
                        _employeelistdictionary.Add(_employee, _employee);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            Console.WriteLine(_employeelistdictionary.Count);
            return _employeelistdictionary;
        }


    }
}

