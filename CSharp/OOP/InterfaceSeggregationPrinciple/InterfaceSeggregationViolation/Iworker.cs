using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSeggregationViolation
{
    interface Iworker
    {
        void StartWork();
        void StopWork();
        void StartEat();
        void StopEat();
    }
}
