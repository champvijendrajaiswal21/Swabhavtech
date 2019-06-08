using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerApp
{
    class Customer
    {
       private  string _firstname;
        string _lastname;
        static int next_sid ;
        int _id;

        public Customer(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
            _id = next_sid++;
        }
        static Customer()
        {
            next_sid = 1001;
        }
        public int ID
        {
            get
            {
                return _id;

            }
        }
    }
}
