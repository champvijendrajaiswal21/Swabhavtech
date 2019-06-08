using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectCalisthenicsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Voilation v = new Voilation();
            v.name = "akash";
            Console.WriteLine("before sorting");
            for(int i=0;i<v._d.Length;i++)
            {
                Console.WriteLine(v._d[i]);
            }
            Console.WriteLine("after sorting");
            v.Sort();
            Console.WriteLine(v);
            Console.WriteLine(v.Isakash());

        }
    }
}
