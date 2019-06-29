using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParser1App
{
    class Control : IHtmlElement
    {
        private string _name;
        private string _type;
        private string _description;
        private StringBuilder strinngBuilder;

        public Control(string name, string type, string description)
        {
            strinngBuilder = new StringBuilder();
            _name = name;
            _type = type;
            _description = description;
        }
        public Control(string name, string type) : this(name, type, null)
        {

        }
        public Control(string name) : this(name, null, null)
        {

        }
        public string ParseToHtml(int count)
        {
            
            return strinngBuilder.Append(new String(' ',count)+"<" + _name + " Type =  " + _type + ">  " + _description + " </" + _name+">").ToString();
        }
    }


}
