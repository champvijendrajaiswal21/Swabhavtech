using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IQueue<int> queue = new QueueAdapter<int>();
                queue.Enqueue(10);
                queue.Enqueue(20);
                queue.Enqueue(30);
                Console.WriteLine("count = "+queue.Count());
                queue.Dequeue();
               
                Console.WriteLine("count = " + queue.Count());
               
               foreach(int element in queue)
                {
                    Console.WriteLine(element);
                }

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
