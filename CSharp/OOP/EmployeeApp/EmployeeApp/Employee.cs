using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    abstract public class Employee
    {
        private string _name;
        private string _dateofjoining;
       protected double _basicsalary;

        public Employee(string name , string dateofjoining , double basicsalary)
        {
            _name = name;
            _dateofjoining = dateofjoining;
            _basicsalary = basicsalary;    

        } 

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string DateOfJoining
        {
            get
            {
                return _dateofjoining;
            }
        }
        public double BasicSalary
        {
            get
            {
                return _basicsalary;
            }

        }
        public override string ToString()
        {
            return "\n Name = " + Name + "\ndate of joining = " + DateOfJoining 
                + "\n salary = " + BasicSalary;
        }
    }
}
