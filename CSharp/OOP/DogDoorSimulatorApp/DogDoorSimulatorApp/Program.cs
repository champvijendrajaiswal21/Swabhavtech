using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoorSimulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("");
            remote.PressButton();
            Thread.Sleep(50);
            Console.WriteLine("Fido has gone out");
            Console.WriteLine("fido all done");
            Console.WriteLine("but he is stuck outside");
            Console.WriteLine("he start barking");
            Console.WriteLine("so gina grab the remote control");
            remote.PressButton();
            Console.WriteLine("he is back inside");
        }
    }
}
