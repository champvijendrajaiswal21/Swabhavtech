using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject1
{
    class Student
    {
        public string GetName(string firstName, string lastName)
        {
            return string.Concat(firstName, " ", lastName);
        }

    }
}
