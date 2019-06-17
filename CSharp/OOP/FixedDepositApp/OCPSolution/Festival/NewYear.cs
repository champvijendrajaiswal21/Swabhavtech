using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSolution.Festival
{
    class NewYear : IFestival
    {
        string fest = "New Year";

        public string Fest
        {
            get
            {
                return fest;
            }
        }

        public double Getrate()
        {
            return 0.08;
        }
    }
}
