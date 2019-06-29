using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParserApp
{
  public  class Control : IHtmlElement
    {
        private string _name;
        private string _type;
        private string _description;
        StringBuilder stringbuilder;

        public Control(string name , string type , string description)
        {
            _name = name;
            _type = type;
            _description = description;
        } 
        public Control(string name):this(name , null , null)
        {

        }
        public Control(string name , string type):this(name,type,null)
        {

        }
       public string ParseToHtml()
        {
            stringbuilder.Append("<"+_name+ " Type="+_type+ " >"+_description+"</"+_name+">");
            return stringbuilder.ToString();
        } 
             
    }
}
