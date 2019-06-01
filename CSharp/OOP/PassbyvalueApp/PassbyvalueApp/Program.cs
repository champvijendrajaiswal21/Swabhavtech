using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassbyvalueApp
{
    class Program
    {
        private static void Changemarkstozero(int Newmarks)
        {
            Newmarks = 0;
        }
        private static void Changemarkstozero(int[] Newmarks)
        {
            for (int i = 0; i < Newmarks.Length; i++)
            {
                Newmarks[i] = 0;
            }
        }
        static void Main(string[] args)
        {
            int[] marks = { 10, 20, 30 };
            int mark = 100;
            Changemarkstozero(mark);
            Console.WriteLine(mark);
            
            Changemarkstozero(marks);
            foreach(int m in marks)
            Console.WriteLine(m);

        }
    }

}
