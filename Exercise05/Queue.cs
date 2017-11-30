using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Queue<T>
    {
        private readonly List<T> list;

        public Queue()
        {
            list = new List<T>();
        }

        public bool Pop()
        {
            if (list.Any())
            {
                list.RemoveAt(0);
                return true;
            } else
            {
                return false;
            }
        }

        public T Front()
        {
            return list.FirstOrDefault();
        }

        public void Add(T t)
        {
            list.Add(t);
        }

        public bool IsEmpty()
        {
            return !list.Any();
        }
    }
}
