using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class DepartmentDb:ICrudable
    {
        public void CreateDb()
        {
            Console.WriteLine(" Department Created");
        }
        public void ReadDb()
        {
            Console.WriteLine("Department accessed");
        }
        public void UpdateDb()
        {
            Console.WriteLine("Department Updated");
        }
        public void DeleteDb()
        {
            Console.WriteLine("Department deleted");
        }
    }
}
