using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterApp
{
    class QueueAdapter<T> : IQueue<T> ,IEnumerable<T>
    {
        LinkedList<T> _queue = new LinkedList<T>();
        private int Position = -1;

      

        public void Enqueue(T element)
        {
            _queue.AddLast(element);
        }
        public T Dequeue()
        {
            T elemant = _queue.First();
            _queue.RemoveFirst();
            return elemant;
        }
       public int Count()
        {
            return _queue.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _queue.GetEnumerator();
        }
    }
}
