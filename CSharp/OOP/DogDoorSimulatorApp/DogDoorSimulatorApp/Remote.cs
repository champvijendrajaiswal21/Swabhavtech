using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Threading;

namespace DogDoorSimulatorApp
{
    class Remote
    {
        private DogDoor _door;
        public Remote(DogDoor door)
        {
            _door = door;
        }
        public void PressButton()
        {
            if (_door.IsOpen())
            {
                _door.Close();
            }
            else
            {
                _door.Open();
                // _door.Close();
                Thread thread = new Thread(Close);
                thread.Start();
               
                
               
            }
           
        }
        public void Close()
        {
           // Thread.Sleep(50);
            _door.Close();
            Console.WriteLine("dog door closes");
        }



    }
}
