using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessinggameApp
{
   public class Game
    {
        public int randomnumber;
        public void TakeRandomNumber()
        {
            this.randomnumber = (int)new Random().Next(100); 
        }

        public int guessnumber(int guessing)
        {
            if(this.randomnumber< guessing)
            {
                return 1;
            }
            if(this.randomnumber> guessing)
            {
                return 2;
            }
            
            return 0;
        }
    }
}
