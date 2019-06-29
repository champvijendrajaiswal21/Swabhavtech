using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    public class AutomobileFactory
    {
        private static AutomobileFactory _factory;
        private AutomobileFactory()
        {

        }
            public IAutomobile Make(AutoType autotype)
        {
            if (autotype == AutoType.AUDI)
                return new Audi();
            if (autotype == AutoType.BMW)
                return new BMW();
            if (autotype == AutoType.TESLA)
                return new Tesla();
            return null;
        }
        public static AutomobileFactory GetInstance()
        {
            if (_factory == null)
                _factory = new AutomobileFactory();
            return _factory;
        }

    }
}
