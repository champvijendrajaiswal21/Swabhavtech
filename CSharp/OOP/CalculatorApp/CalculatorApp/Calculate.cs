using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorLib;

namespace CalculatorApp
{
    class Calculate
    {
        private int  _number1;
        private int _number2;

        public Calculate(int number1 , int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public int Addition ()
        {
           return Calculator.Add(_number1, _number2);

           
        }
        public int Number1
        {
            get
            {
                return _number1;
            }
            }
        public int Number2
        {
            get
            {
                return _number2;
            }
        }
    }
}
