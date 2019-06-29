using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            new Addition(subject);
            Console.WriteLine("Addition : 10");
            subject.SetState(10);
        }
    }
}
