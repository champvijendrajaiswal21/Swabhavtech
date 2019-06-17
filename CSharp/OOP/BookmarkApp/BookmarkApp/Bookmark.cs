using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BookmarkApp
{
    class Bookmark
    {
        Dictionary<string, string> _links = new Dictionary<string, string>();
       public  Bookmark(Dictionary<string, string> links)
        {
            _links = links;
        }
       public void Create()
        {
            using (FileStream fs = new FileStream("C:/Users/champ/Desktop/test.html", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    foreach (KeyValuePair<string, string> link in _links)

                    {
                        w.WriteLine("<br><a href =" + link.Key + ">" + link.Value + "</a>");
                        w.WriteLine();
                    }
                }
            }
        }
    }
}
