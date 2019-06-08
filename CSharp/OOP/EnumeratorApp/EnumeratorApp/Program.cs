using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumeratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("February");
            Month.Add("March");
            Month.Add("April");
            Month.Add("May");
            Month.Add("June");
            Month.Add("July");
            Month.Add("August");
            Month.Add("September");
            Month.Add("October");
            Month.Add("November");
            Month.Add("December");

            IEnumerable<string> iEnumerableOfMonths = (IEnumerable<string>)Month;


            Console.WriteLine("iEnumerable");
            foreach (string AllMonths in iEnumerableOfMonths)
            {
                Console.WriteLine(AllMonths);
            }
            IEnumerator<string> iEnumeratorOfMonths = Month.GetEnumerator();
            Console.WriteLine();
            Console.WriteLine("iEnumerator");
            while (iEnumeratorOfMonths.MoveNext())
            {
                Console.WriteLine(iEnumeratorOfMonths.Current);
            }
            iEnumeratorOfMonths.Reset();
            Console.WriteLine(iEnumeratorOfMonths.Current);
            Console.WriteLine("finish");
        }
    }
}
