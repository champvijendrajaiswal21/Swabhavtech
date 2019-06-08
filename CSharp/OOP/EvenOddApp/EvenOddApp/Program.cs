using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace EvenOddApp
{
    class Program
    {
        static void Display(ArrayList list)
        {
            foreach(int number in list)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            EvenOdd evenodd_object = new EvenOdd();
            Console.WriteLine("Even:\n");
            Display(evenodd_object.Even());
            Console.WriteLine("Odd:\n");
            Display(evenodd_object.Odd());
          
        }
    }
}
