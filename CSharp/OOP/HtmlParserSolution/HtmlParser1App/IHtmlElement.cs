using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParser1App
{

    interface IHtmlElement
    {
        string ParseToHtml(int count);
    }
}
