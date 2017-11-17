using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Queue<T>
    {
        public List<T> list { set; get; }

        public Queue()
        {
            list = new List<T>();
        }

        public void Pop()
        {
            try
            {
                list.RemoveAt(0);
            } catch (Exception e)
            {
                Console.WriteLine("Queue is empty");
            }
        }

        public T Front()
        {
            try
            {
                return list.First();
            } catch (Exception e)
            {
                Console.WriteLine("Queue is empty");
            }
            return default(T);
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
