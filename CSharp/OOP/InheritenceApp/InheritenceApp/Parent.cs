using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritenceApp
{
    class Parent
    {
        int parent1,parent2;
        public Parent()
        {
            parent1 = 0;
            Console.WriteLine("parent class default constructor");
        }

        public Parent(int p):this()
        {
            parent2 = p;
            Console.WriteLine("parent class parameterized constructor");
        }
    }
}
