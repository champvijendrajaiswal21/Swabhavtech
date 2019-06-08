using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManBoyApp.Constructor.case2
{
    class Parent
    {
        private int _bar;
        public Parent(int bar)
        {
            _bar = bar;
        }
        public int Bar
            {
            get
            {
                return _bar;
            }
            }
    }
}
