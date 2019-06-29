using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterApp
{
    interface IQueue<T> : IEnumerable<T>
    {
       void Enqueue(T element);
        T Dequeue();
        int Count();
    }
}
