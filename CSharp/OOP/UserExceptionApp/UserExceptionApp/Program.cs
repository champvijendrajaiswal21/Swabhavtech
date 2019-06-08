using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserExceptionApp
{
    class Program
    {
        static void Valid(string s)        
        {
            if (!s.Equals("akash"))
            {
              throw new NotAkash("invalid user");
            }

        }

        static void Main(string[] args)
        {
            try
            {
                Valid("sanal");
            }
            catch(NotAkash e)
            {
                Console.WriteLine(e);
                Console.WriteLine("it is not akash");
            }
        }
    }
}

