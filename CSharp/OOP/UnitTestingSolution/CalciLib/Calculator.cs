using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalciLib
{
   public class Calculator
    {
        public int CubeofEvenNumber(int number)
        {
            if(number < 0)
            {
                throw new NegativeNumberException("it is negative number");
            }
            if(number% 2== 0)
            {
                return (number*number*number);
            }
            throw new NotEvenException("not an Even Number");
            
        }
    }
}
