using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileFactoryLib
{
   public class BMWFactory : IAutoMobileFactory
    {
        private static BMWFactory _bmw; 
        private BMWFactory()
        {

        }
       public  IAutomobile Make()
        {
            return new BMW();
        }
        
        public static BMWFactory GetInstance()
        {
            if (_bmw == null)
                _bmw = new BMWFactory();
            return _bmw;
        }
    }
}
