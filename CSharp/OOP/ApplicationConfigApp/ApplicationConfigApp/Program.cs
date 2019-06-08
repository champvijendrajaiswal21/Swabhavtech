using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ApplicationConfigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringvalue1 = ConfigurationManager.AppSettings["key1"];
            string stringvalue2 = ConfigurationManager.AppSettings["key2"];
            string stringvalue3 = ConfigurationManager.AppSettings["key3"];
            Console.WriteLine(stringvalue1+"  "+stringvalue2+"  "+stringvalue3);
        }
    }
}
