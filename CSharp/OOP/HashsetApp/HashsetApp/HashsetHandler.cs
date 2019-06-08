using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashsetApp
{
    class HashsetHandler
    {
        public HashSet<string> Employees = new HashSet<string>();

        public void Add()
        {
            Employees.Add("akash");
            Employees.Add("dhruv");
            Employees.Add("sanal");
            Employees.Add("dipesh");

        }
        public void Remove()
        {
            Employees.Remove("dipesh");
        }
       
        public void Search()
        {
            if(Employees.Contains("akash"))
            {
                Console.WriteLine("akash found");
            }
        }

    }
   
}
