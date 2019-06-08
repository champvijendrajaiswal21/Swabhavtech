using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManBoyApp
{
    class Boy: Man
    {
       override public void Play()
        {
            Console.WriteLine("boy is playing");
        }
        public void Eat()
        {
            Console.WriteLine("Boy is eating");
        }
    }
}
