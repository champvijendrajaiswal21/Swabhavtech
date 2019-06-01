using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumApp
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon;
            
            int WeekdayEnd = (int)Days.Sat;

            Console.WriteLine("Monday: "+ WeekdayStart);
            Console.WriteLine("Saturday: "+ WeekdayEnd);
            
        }
    }
}