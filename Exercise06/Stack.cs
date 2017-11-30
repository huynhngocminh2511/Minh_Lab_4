using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Stack<T>
    {
        private readonly List<T> list;

        public Stack()
        {
            list = new List<T>();
        }

        public bool Pop()
        {
            if (list.Any())
            {
                list.RemoveAt(list.Count - 1);
                return true;
            } else
            {
                return false;
            }
        }

        public T Top()
        {
            return list.LastOrDefault();
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
