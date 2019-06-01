using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureApp
{
    public struct Person
    {
        public String name;
        public int age;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p.name = "Akash";
            p.age = 21;
            Console.WriteLine("name of person is "+p.name+" his age is "+p.age); 
        }
    }
}
