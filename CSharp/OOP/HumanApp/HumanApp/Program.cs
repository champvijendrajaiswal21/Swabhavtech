using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanApp
{
    class Program
    {
        public static void Info(Human h)
        {
            Console.WriteLine("Name = " + h.Name);
            Console.WriteLine("height = " + h.Height);
            Console.WriteLine("weight = " + h.Weight);
            Console.WriteLine("age = " +h.Age);
            Console.WriteLine(" gender = "+h.Gender);

        }
        static void Main(string[] args)
        {
            Human h1 = new Human("akash",5.5f,50.0f,21);
            Human h2 = new Human("dhruv",6.0f,65.5f);
            h1.Gender = "male";
            h2.Gender = "female";
            Info(h1);
            Console.WriteLine("after workout");
            h1.Workout();
            Info(h1);
            Info(h2);
            Console.WriteLine("after eating");
            h2.Eat();
            Info(h2);
            
                

        }
    }
}
