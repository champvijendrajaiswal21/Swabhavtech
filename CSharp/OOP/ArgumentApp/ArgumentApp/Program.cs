using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            if (args.Length > 0)
            {
                foreach (string s in args)
                {
                    Console.WriteLine("hello  " + s);
                }
            }
            else
            {
                Console.WriteLine("no parameter passed");
            }
        }
    }
}
