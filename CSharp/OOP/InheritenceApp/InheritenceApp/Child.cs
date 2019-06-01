using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritenceApp
{
    
     class Child : Parent
    {
        int childvar;
       
        public Child(int c):base(c) 
        {
            childvar = c;
            Console.WriteLine( "child class constructor");
        }
    }
}
