using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Developer : Employee
    {
        private readonly double _bonus;
        private readonly double _pa;

        public Developer(string name, string dateofjoining, double basicsalary)
            : base(name, dateofjoining, basicsalary)
        {
            _bonus = 0.4 * basicsalary;
            _pa = 0.3 * basicsalary;
        }
        public double Bonus
        {
            get
            {
                return _bonus;
            }
        }
        public double PerformanceAllowance
        {
            get
            {
                return _pa;
            }
        }
        public double CalculateDeveloperAllowance
        {
            get
            {
                return (_bonus+_pa);
            }
        }
        public override string ToString()
        {
            return base.ToString()+"\n bonus = "+Bonus+"\n PA"+PerformanceAllowance+"\n Total Salary="+CalculateDeveloperAllowance+BasicSalary;
        }

    }
}
