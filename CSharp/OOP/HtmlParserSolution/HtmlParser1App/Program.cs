using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParser1App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ControlGroup controlGroup = new ControlGroup("div","div1");
                Control control = new Control("button","toggle","Hello");
                ControlGroup div2 = new ControlGroup("div","div2");
                Control control2 = new Control("h1" ," ","title");
                div2.AddChild(control2);
                controlGroup.AddChild(control);
                controlGroup.AddChild(div2);

                Console.WriteLine(controlGroup.ParseToHtml(0));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
