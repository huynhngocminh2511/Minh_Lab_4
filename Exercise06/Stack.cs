using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Stack<T>
    {
        public List<T> list { set; get; }

        public Stack()
        {
            list = new List<T>();
        }

        public void Pop()
        {
            try
            {
                list.RemoveAt(list.Count - 1);
            } catch (Exception e)
            {
                Console.WriteLine("Stack is empty");
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

        public bool Isempty()
        {
            return (list.Count == 0);
        }
    }
}
