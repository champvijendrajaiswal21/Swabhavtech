using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoorSimulatorApp
{
    class DogDoor
    {
        private bool _open;
        public DogDoor()
        {
            _open = false;
        }  
        public void Open()
        {
            _open = true;
            Console.WriteLine("dog door opens");
        }
        public void Close()
        {
            _open = false;
            Console.WriteLine("dog door close");
        }
        public bool IsOpen()
        {
            return _open;
        }
    }
}
