using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Manager : Employee
    {
        private readonly  double _hra;
        private readonly double _ta;
        private readonly double _da;

        public Manager(string name , string dateofjoining , double basicsalary  )
            : base(name , dateofjoining,basicsalary )
        {
            _hra = 0.5*basicsalary;
            _ta = 0.4*basicsalary;
            _da = 0.3*basicsalary;
        }
        public double CalculateManagerAllowance
        {
            get
            {
                return (_hra+_ta+_da);
            }
        } 
        public double HouseRentalAllowance
        {
            get
            {
                return _hra;
            }
        }
        public double DearnessAllowance
        {
            get
            {
                return _da;
            }
        }
        public double TravelAllowance
        {
            get
            {
                return _ta;
            }
        }
        public override string ToString()
        {
            return base.ToString()+"\n HRA = " +HouseRentalAllowance+"\n DA"
                +"\n DA = "+DearnessAllowance+"\n TA = "+TravelAllowance+"total salary = "
                +CalculateManagerAllowance+BasicSalary;
        }

    }
}
