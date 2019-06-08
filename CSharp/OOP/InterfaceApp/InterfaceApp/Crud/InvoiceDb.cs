using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class InvoiceDb:ICrudable
    {
        public void CreateDb()
        {
            Console.WriteLine(" Invoice Created");
        }
        public void ReadDb()
        {
            Console.WriteLine("Invoice accessed");
        }
        public void UpdateDb()
        {
            Console.WriteLine("Invoice Updated");
        }
        public void DeleteDb()
        {
            Console.WriteLine("Invoicer deleted");
        }
    }
}
