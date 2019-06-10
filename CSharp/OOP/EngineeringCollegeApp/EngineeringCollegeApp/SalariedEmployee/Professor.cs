using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringCollegeApp.SalariedEmployee
{
    public class Professor:Person, ISalariedEmployee
    {
        private double _salary;
        private double _bonus;

        public Professor(int id , DateTime dateofbirth , string address  ,double salary , double bonus)
            : base (id,dateofbirth,address)
        {
            _salary = salary;
            _bonus = bonus;
        }

        public double Salary
        {
            get
            {
                return _salary;
            }
        }
        public double Bonus
        {
            get
            {
                return _bonus;
            }
        }

        public double CalculateSalary()
        {
            return (_salary + _bonus);
        }
    }
}
