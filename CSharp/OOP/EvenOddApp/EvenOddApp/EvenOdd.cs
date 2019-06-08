using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenOddApp
{
   
    class EvenOdd
    {
        
        public ArrayList Even()
        {
            ArrayList arraynumber = new ArrayList();
            for (int i=0;i<=100;i++)
            {
                if(i%2==0)
                {
                    arraynumber.Add(i);
                }
            }
            return arraynumber;
        }
        public ArrayList Odd()
        {
            ArrayList arraynumber = new ArrayList();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    arraynumber.Add(i);
                }
            }
            return arraynumber;
        }
    }
}
