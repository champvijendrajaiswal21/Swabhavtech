using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoorSimulatorApp
{
    class BarkRecognizer
    {
        private DogDoor _door;

        public BarkRecognizer (DogDoor door)
        {
            _door = door;
        }

        public void Recognize(Bark bark)
        {
            Console.WriteLine("Bark Recognizer heard a " + bark.GetSound());
            // ArrayList allowedBarks = _door.AllowedBarks;
            foreach (Bark dogBark in _door.GetAllowedBark())
            {
                if (dogBark.Equal(bark))
                {
                    _door.Open();
                    return;
                }
            }
            Console.WriteLine("This dog is not allowed..");

        }
        }
    }
