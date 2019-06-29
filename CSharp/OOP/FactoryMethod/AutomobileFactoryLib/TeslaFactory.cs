using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileFactoryLib
{
    public class TeslaFactory : IAutoMobileFactory
    {
        private static TeslaFactory _tesla;
        private TeslaFactory()
        {

        }
        public IAutomobile Make()
        {
            return new Tesla();
        }
        public static TeslaFactory GetInstance()
        {
            if (_tesla == null)
                _tesla = new TeslaFactory();
            return _tesla;
        }
    }
}
