using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManBoyApp.Constructor.case2
{
    class Child:Parent
    {
        public Child():base(100)
        {

        }
        public Child(int bar):base(bar)
        {

        }
    }
}
