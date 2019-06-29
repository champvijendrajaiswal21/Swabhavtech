using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileFactoryLib
{
  public  class AudiFactory : IAutoMobileFactory
    {
        private static AudiFactory _audi;
        private AudiFactory()
        {

        }
        public IAutomobile Make()
        {
            return new Audi();
        }
        public static AudiFactory GetInstance()
        {
            if (_audi == null)
                _audi = new AudiFactory();
            return _audi;
        }
    }
}
