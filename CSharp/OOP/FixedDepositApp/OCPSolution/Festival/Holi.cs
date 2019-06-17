using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSolution.Festival
{
   public  class Holi : IFestival
    {
        string fest = "Holi";
        public string Fest
        {
            get
            {
                return fest;
            }
        }

        public double Getrate()
        {
            return 0.95;
        }

    }
}
