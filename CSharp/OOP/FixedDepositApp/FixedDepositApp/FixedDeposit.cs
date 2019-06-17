using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedDepositApp
{
    class FixedDeposit
    {
        private string _name;
        private double _principle;
        private int _year;
        private Festival _festival;

        public FixedDeposit(string name, double principle, int year, Festival festival)
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
        public Festival FEstival
            {
            get
            {
                return _festival;
            }
            }
    public double CalculateSimpleInterest()
        {
            if (_festival.Equals(Festival.HOLI))
                return (_principle * _year * 0.08)/100;
            if (_festival.Equals(Festival.NEWYEAR))
                return (_principle * _year * 0.95)/100;
            return (_principle * _year * 0.7)/100;
                
            
        }
        
    }
}
