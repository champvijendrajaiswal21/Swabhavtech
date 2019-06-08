using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryApp
{
    class DictonaryHandler
    {
        public Dictionary<int, string> Employees = new Dictionary<int, string>();
       public void Add()
        {
            Employees.Add(1, "akash");
            Employees.Add(2, "sanal");
            Employees.Add(3, "dipesh");
            Employees.Add(1, "apple");
        }
       public void Remove()
        {
            Employees.Remove(3);
        }
        public void Update()
        {
            Employees[1] = "james";
        }
        public void search()
        {
            if(Employees.ContainsValue("james"))
            {
                Console.WriteLine("james is present");
            }
        }
    }
}
