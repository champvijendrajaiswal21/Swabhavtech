using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace BookmarkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> links = new Dictionary<string,string>();
            string url = "https://www.google.com";
            string url1 = "https://www.wikipedia.org";
            string name = "Google";
            string name1 = "wiki";
            links.Add(url, name);
            links.Add(url1, name1);
            Bookmark bookmark = new Bookmark(links);
            bookmark.Create();
                

          
        }
    }
}
