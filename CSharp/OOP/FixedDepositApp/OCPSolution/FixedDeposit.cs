using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OCPSolution.Festival;

namespace OCPSolution
{
    class FixedDeposit
    {
        private string _name;
        private double _principle;
        private int _year;
        private IFestival _festival;

        public FixedDeposit(string name, double principle, int year,IFestival festival )
        {
            _name = name;
            _principle = principle;
            _year = year;
            _festival = festival;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Principle
        {
            get
            {
                return _principle;
            }
        }
        public int year
        {
            get
            {
                return _year;
            }
        }
        public string FEstival
        {
            get
            {
                return _festival.ToString();
            }
        }
        public double CalculateSimpleInterest()
        {
          
                return (_principle * _year * _festival.Getrate()) / 100;
         ;


        }

    }
}
