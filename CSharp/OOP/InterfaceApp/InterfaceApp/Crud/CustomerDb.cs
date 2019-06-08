using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class CustomerDb:ICrudable
    {
        public void CreateDb()
        {
            Console.WriteLine(" Customer Created");
        }
        public void ReadDb()
        {
            Console.WriteLine("Customer accessed");
        }
        public void UpdateDb()
        {
            Console.WriteLine("Customer Updated");
        }
        public void DeleteDb()
        {
            Console.WriteLine("Customer deleted");
        }
    }
}
