using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParser1App
{
    class ControlGroup : IHtmlElement
    {
        private string _tagName;
        private string _id;
        private List<IHtmlElement> _childrens;
        private StringBuilder _stringBuilder;
        int _count = 0;

        public ControlGroup(string tagName, string id)
        {
            _childrens = new List<IHtmlElement>();
            _tagName = tagName;
            _id = id;
            _stringBuilder = new StringBuilder();
        }
        public ControlGroup(string tagName) : this(tagName, null)
        {

        }
        public void AddChild(IHtmlElement element)
        {
            _childrens.Add(element);
        }
        public string ParseToHtml(int count)
        {
            _stringBuilder.Append(new String(' ', count) );
            
            _stringBuilder.Append("\n<" + _tagName +" id = " + _id + ">\n");
            foreach (IHtmlElement element in _childrens)
                _stringBuilder.Append(element.ParseToHtml(count+2));
            _stringBuilder.Append("\n</" + _tagName + ">");
            return _stringBuilder.ToString();

        }
    }
}
