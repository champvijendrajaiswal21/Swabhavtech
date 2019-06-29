using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder Movie = new Folder("Movie");
            Folder hindi = new Folder("Hindi");
            Folder English = new Folder("English");
            Folder comedy = new Folder("Comedy");
            File B = new File("B", "avi", 1024);
            File A = new File("A", "avi", 1024);
            File LMN = new File("lmn","avi",2048);
            File pqr = new File("pqr","avi",2048);
            File abc = new File("abc","avi",2048);
            comedy.Add(B);
            English.Add(A);
            hindi.Add(LMN);
            Movie.Add(abc);
            Movie.Add(pqr);
            Movie.Add(hindi);
            Movie.Add(English);
            Movie.Add(comedy);
            Movie.Display(0); 
        }
    }
}
