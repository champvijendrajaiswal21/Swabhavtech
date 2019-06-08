using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Sealed_Class sealedobject = new SealedClass.Sealed_Class();
           int sum = sealedobject.Add(10, 20);
            Console.WriteLine("sum of two = "+sum);    
        }
    }
}
