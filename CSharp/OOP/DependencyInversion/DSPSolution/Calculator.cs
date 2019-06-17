using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPSolution
{
   public class Calculator
    {
        ILogger _logger;

        public  Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public int Calculate(int income, int rate)
        {
            int r = 0;
            try
            {
                r = income / rate;
            }
            catch (Exception e)
            {
                _logger.log(e.Message);
            }
            return r;
        }


    }
}
