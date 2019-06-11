using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EmployeeManagementApp
{
    class RecordAnalyzer
    {
        public Employee MaximumSalariedEmployee
            (Dictionary<Employee, Employee> employeedictionary)
        {
            int max = 0;
            Employee maxemployee = null;
            foreach (Employee employee in employeedictionary.Values)
            {
                if (max < Convert.ToInt32(employee.EmployeeSalary))
                {
                    max = Convert.ToInt32(employee.EmployeeSalary);
                    maxemployee = employee;
                }

            }
            return maxemployee;

        }
        public Dictionary<string,int> DepartmentWiseCount
             (Dictionary<Employee, Employee> employeedictionary)
        {
            
            Dictionary<string, int> count = new Dictionary<string, int>(); ;
           
       
            foreach (Employee employee in employeedictionary.Values)
            {
                if(count.ContainsKey(employee.DepartmentNumber))
                {
                    int value = 0;
                    count.TryGetValue(employee.DepartmentNumber, out value);
                        count[employee.DepartmentNumber] = value + 1;

                }
                else
                {
                    count[employee.DepartmentNumber] = 1;
                }
               
                }

            return count;


        }

        public Dictionary<string,int> DesignationWiseCount
        (Dictionary<Employee, Employee> employeedictionary)
        {
            Dictionary<string, int> count = new Dictionary<string, int>(); ;


            foreach (Employee employee in employeedictionary.Values)
            {
                if (count.ContainsKey(employee.EmployeeDesignation))
                {
                    int value = 0;
                    count.TryGetValue(employee.EmployeeDesignation, out value);
                    count[employee.EmployeeDesignation] = value + 1;

                }
                else
                {
                    count[employee.EmployeeDesignation] = 1;
                }

            }

            return count;
        }


        }
    }

