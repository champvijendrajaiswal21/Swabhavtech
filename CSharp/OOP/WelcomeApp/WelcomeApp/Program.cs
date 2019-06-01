using System;


namespace WelcomeApp
{
   
    class Program
    {
       private static void PrintInfo(string s)
        {
            Console.WriteLine("first overload");
            Console.WriteLine(s);

        }
         private static void PrintInfo(char s)
        {
            Console.WriteLine("second overload");
            Console.WriteLine(s);

        }
        private static void PrintInfo(float s)
        {
            Console.WriteLine("third overload");
            Console.WriteLine(s);

        }
        private static void PrintInfo(double s)
        {
            Console.WriteLine("fouth overload");
            Console.WriteLine(s);

        }
        private static void PrintInfo(bool s)
        {
            Console.WriteLine("five overload");
            Console.WriteLine(s);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to csharp");
            Console.WriteLine(24);
            Console.WriteLine('a');
            Console.WriteLine(7.2);
            Console.WriteLine(true);
            Console.WriteLine(7.2222222);
            PrintInfo(true);
            PrintInfo("akash");
            PrintInfo('a');
            PrintInfo(7.2f);
            PrintInfo(7.22222);


        }
    }
}
