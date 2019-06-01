using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadWriteFileApp
{
    class Program

    {
        public static readonly string address = "C:/SwabhavRespo/new.txt";
        static void FileRead( )
        {
           
            try
            {
                using (StreamReader s = new StreamReader(address))
                {
                    String Line;

                    while ((Line = s.ReadLine()) != null)
                    {
                        Console.WriteLine(Line);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        static void FileWrite()
        {

            try
            {
               using (FileStream fs = new FileStream(address,FileMode.Append))
                using (StreamWriter w = new StreamWriter(fs))
                {
                    string[] Line = new string[] { "hi i m akash", "i want to b good programmer" };
                    foreach (string dup in Line)
                    {
                        w.WriteLine(dup);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine( "file could be write");
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {

            FileRead();
            FileWrite();
           

        }
    }
}
