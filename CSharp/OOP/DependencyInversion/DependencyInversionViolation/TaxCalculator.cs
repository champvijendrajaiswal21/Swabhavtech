using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionViolation
{
   public class TaxCalculator
    {
        private LogType _log;

       public  TaxCalculator(LogType log)
        {
            _log = log;
        }

        public int Calculate(int income , int rate)
        {
            int r=0;
            try
            {
                r = income / rate;
            }
            catch(Exception e)
            {
                if(_log == LogType.DB)
                {
                    DBLogger db = new DBLogger();
                    db.log(e.Message);
                }
                else
                {
                    FileLogger file = new FileLogger();
                    file.log(e.Message);
                }
            }
            return r;
        }

    }
}
