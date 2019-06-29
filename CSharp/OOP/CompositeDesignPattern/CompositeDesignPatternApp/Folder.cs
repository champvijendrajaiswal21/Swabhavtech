using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDesignPatternApp
{
    class Folder : IDiskItem
    {
        readonly private string _name;
        private List<IDiskItem> _content;
      
       
        
        public Folder(string name)
        {
            _name = name;
            _content = new List<IDiskItem>();
        }
            
            


        public void Display(int count)
        {
            count++;
            Console.Write(new string('\t',count));
           
            Console.WriteLine("name of folder = " + _name);
            Console.WriteLine();
            
            foreach(IDiskItem item in _content)
            {
                item.Display(count);
            }
        }
        public void Add(IDiskItem item)
        {
            _content.Add(item);
        }
    }
}
