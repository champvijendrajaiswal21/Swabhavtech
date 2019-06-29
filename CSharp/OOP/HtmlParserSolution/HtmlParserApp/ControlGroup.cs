using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParserApp
{
   public  class ControlGroup :IHtmlElement
    {
        private string  _name;
        private string _id;
        private List<IHtmlElement> _childrens;
        StringBuilder stringbuilder;

        public ControlGroup(string name , string id )
        {
            _name = name;
            _id = id;
            _childrens = new List<IHtmlElement>();
            
        }
        public void Add(IHtmlElement element)
        {
            _childrens.Add(element);
        }
      public  string ParseToHtml()
        {
            stringbuilder.Append("< "+_name+ " id = "+_id+">");
            foreach (IHtmlElement elements in _childrens)
                stringbuilder.Append(elements.ParseToHtml());
            stringbuilder.Append("<"+_name +"/>"); 

            return stringbuilder.ToString();
        }
    }
}
