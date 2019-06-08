using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithoutnewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            
            object obj = Activator.CreateInstance(type);
            MyClass myClass = obj as MyClass;
            myClass.Display();
            
        }
    }
}
