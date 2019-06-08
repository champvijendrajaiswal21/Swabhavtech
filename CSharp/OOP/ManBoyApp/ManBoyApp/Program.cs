using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManBoyApp.Constructor.case1;

namespace ManBoyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
            Case4();
            Case5();
            Case6();
        }

        private static void Case6()
        {
            Constructor.case2.Child child = new Constructor.case2.Child();
            Console.WriteLine(child.Bar);
            Constructor.case2.Child child1 = new Constructor.case2.Child(200);
            Console.WriteLine(child1.Bar);

        }

        public static void Case1()
        {
            
           Man man = new Man();
            Console.WriteLine("case1");
            man.Play();
            man.Walk();
           
        }
        public static void Case2()
        {
            Boy boy = new Boy();
            Console.WriteLine("case 2");
            boy.Play();
            boy.Eat();
            boy.Walk();
            
            
        }
        public static void Case3()
        {
            Man man;
            Console.WriteLine("case 3");
            man = new Boy();
            man.Walk();
            man.Play();
        }
        public static void Case4()
        {
            Console.WriteLine("case 4");
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());

        }
        public static void AtThePark(Man man)
        {
            Console.WriteLine("Inside the park");
            man.Play();
                
        }
        public static void Case5()
        {
            Console.WriteLine("case 5");
            new Child();
        }

    }
}
