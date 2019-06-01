using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(1,"akash",GenderOptions.male);
            Player p2 = new Player(2, "dhruv");
            Info(p1);
            Info(p2);
            Player sachin = new Player();
        }
        static void Info(Player p)
        {
            Console.WriteLine("name = "+ p.Name);
            Console.WriteLine("id = "+ p.Id);
            Console.WriteLine("Gender = "+p.Gender);

        }
        

        
    }
}
