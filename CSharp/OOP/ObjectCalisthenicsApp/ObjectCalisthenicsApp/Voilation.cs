using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectCalisthenicsApp
{
    public class Voilation
    {
        public String name;
       public int[] _d= { 30,20,10};
       public Voilation()
        {

        }

       public void Sort() 
        {
            int temp;
            for(int i=0;i<_d.Length;i++)
            {
                for(int j=0;j<_d.Length;j++)
                {
                    if (_d[j] > _d[j + 1])
                    {
                        temp = _d[j];
                        _d[j] = _d[j + 1];
                        _d[j + 1] = temp;
                    }
                }
            }
            
        }
        public string Isakash()
        {
            if(this.name.Equals("akash"))
            {
                return "it is akash";

            }
            else
            {
                return "it is not akash";
            }
        }
            
       
    }
}
