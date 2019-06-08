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
            int guessednumber = 1;
            int rotate = 0;
            Game game = new Game();
            game.TakeRandomNumber();
            do
            {

                Console.WriteLine(game.randomnumber);
                Console.WriteLine("enter no");
                guessednumber = Convert.ToInt32(Console.ReadLine());
             
               
                if (game.guessnumber(guessednumber) == 2)
                {
                    Console.WriteLine("your number is smaller then random number");

                }
                if (game.guessnumber(guessednumber) == 1)
                {
                    Console.WriteLine("your number is larger then random number");

                }
                if (game.guessnumber(guessednumber) == 0)
                {
                    Console.WriteLine("you have guessed correct number");

                    game.TakeRandomNumber();
                }

                Console.WriteLine("enter 0 to continue ");
                Console.WriteLine("enter -1 to exit");
                rotate = Convert.ToInt32(Console.ReadLine());


            } while (rotate!=1);
        }
    }
}
