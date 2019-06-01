using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UrlApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url;
            url = args[0];
            string[] breakstr;
            char[] breakpt = { '/','&','.',',','?','='};
            breakstr = url.Split(breakpt);
            for(int i=0;i< breakstr.Length;i++)
            {
                if(breakstr[i] == "www")
                {
                    Console.WriteLine("company = "+ breakstr[i+1]);
                }
                if (breakstr[i] == "developer")
                {
                    Console.WriteLine("developer = " + breakstr[i + 1]);
                }
                if (breakstr[i] == "location")
                {
                    Console.WriteLine("location = " + breakstr[i + 1]);
                }
                
            }

        }
    }
}
