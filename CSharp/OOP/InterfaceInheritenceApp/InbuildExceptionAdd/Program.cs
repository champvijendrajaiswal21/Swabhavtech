using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InbuildExceptionAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Int32.Parse(args[0]);
                int b = Int32.Parse(args[1]);
                int c = a / b;
                Console.WriteLine("result = "+c);
                m1();
            }
          //  catch (DivideByZeroException exception)
           // {
            //    Console.WriteLine(exception);
           // }
           catch (IndexOutOfRangeException exception )
            {
                Console.WriteLine(exception.Message);
            }
            catch (StackOverflowException exception)
            {
                Console.WriteLine(exception);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Console.WriteLine("end of main");

        }
        static void m1()
        {
            Console.WriteLine("inside m1");
            m2();
        }
        static void m2()
        {
            Console.WriteLine("inside m2");
            m3();
        }
        static void m3()
        {
            Console.WriteLine("inside m3");
            throw new Exception("M3 exception");

        }
    }
}
