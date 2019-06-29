using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlGroup div = new ControlGroup("div", "div1");
            Control button = new Control("button");
            div.Add(button);
            Console.WriteLine(   div.ParseToHtml());
        }
    }
}
