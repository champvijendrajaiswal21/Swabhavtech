using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorProg
{
    class Demo
    {
        private int n;
        private float m;
        public Demo()
        {
            n = 0;
            m = 0;
        }
        public Demo(int n)
        {
            this.n = n;
            m = 0;
        }
       public  Demo(float m)
        {
            this.m = m;
            n = 0;
        }
         public void display()
        {
            Console.WriteLine("n = "+n);
            Console.WriteLine("m = "+m);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            Demo d2 = new Demo(10);
            Demo d3 = new ConstructorProg.Demo(10.23f);
            d1.display();
            d2.display();
            d3.display();
            int num = 23;        
            Object Obj = num;
            Console.WriteLine("after boxing ie value into obj");
            Console.WriteLine("num = " + num);
            Console.WriteLine("obj = "+Obj);  
            int i = (int)Obj;
            Console.WriteLine(" after unboxing obj into value");
            Console.WriteLine("i ="+i);
            Console.WriteLine("obj = " + Obj);
        }
    }
}
