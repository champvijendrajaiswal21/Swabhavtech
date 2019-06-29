using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDesignPatternApp
{
    class File : IDiskItem
    {
       readonly private string _name;
       readonly private string _extension;
       readonly private int  _size;
         
        public File (string name , string extension , int size)
        {
            _name = name;
            _extension = extension;
            _size = size;

        }
        public void Display(int count)
        {
            count++;

            Console.Write(new string('\t',count));
            Console.WriteLine("name of file = "+_name );
            Console.Write(new string('\t', count));
            Console.WriteLine("extension = "+_extension );
            Console.Write(new string('\t', count));
            Console.WriteLine("size = "+_size );
            Console.WriteLine();
        }
    }
}
