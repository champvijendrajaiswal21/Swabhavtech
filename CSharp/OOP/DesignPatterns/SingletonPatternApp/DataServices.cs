using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternApp
{
   public  class DataServices
    {
        private static DataServices Container;
        private DataServices()
        {
            Console.WriteLine("service created");
        }
        public void  DoSomething()
        {
            Console.WriteLine("data service by "+this.GetHashCode());
        }
        public static DataServices GetInstance()
        {
            if (Container == null)
                Container = new DataServices();
            return Container;

        }
    }
}
