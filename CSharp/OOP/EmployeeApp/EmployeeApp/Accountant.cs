using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Accountant : Employee
    {
        private readonly double _perk;

        public Accountant(string name, string dateofjoining, double basicsalary)
            : base(name, dateofjoining, basicsalary)
        {
            _perk = 0.3*basicsalary;
        }

        public double CalculateAllowance
        {
            get
            {
                return _perk;
            }
        }
        public double Perk
        {
            get
            {
                return _perk;
            }
        }
        public override string ToString()
        {
            return base.ToString()+"\n perk = "+Perk+"\n total salary = "+BasicSalary+CalculateAllowance;
        }
    }
}
