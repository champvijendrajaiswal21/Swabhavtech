using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessinggameApp
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int game = 0,start =0;
            int num;
            Random r = new Random();
            do
            {
                
             
                num = (int)r.Next(100);
                game = 999;
                while(num!=game)
                {
                    Console.WriteLine("enter no");
                    game = Convert.ToInt32(Console.ReadLine());
                    if(num==game)
                    {
                        Console.WriteLine("you have guessed correct number");
                        break;
                    }
                    if(num<game)
                    {
                        Console.WriteLine("your number is larger then random number");

                    }
                    if(num>game)
                    {
                        Console.WriteLine("your number is smaller then random number");
                    }
                }

                Console.WriteLine("enter 1 to continue ");
                Console.WriteLine("enter 2 to exit");
                start = Convert.ToInt32(Console.ReadLine());
            } while (start == 1);
        }
    }
}
