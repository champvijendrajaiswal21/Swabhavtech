using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSolution.Festival
{
    class Normal : IFestival
    {
        string fest = "Normal";
        public string Fest
        {
            get
            {
                return fest;
            }
        }

        public double Getrate()
        {
            return 0.07;
        }
    }
}
