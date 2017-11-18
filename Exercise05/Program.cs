using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Front());
                queue.Pop();
            }
            var queue2 = new Queue<string>();
            queue2.Add("a");
            queue2.Add("b");
            queue2.Add("c");
            while (!queue2.IsEmpty())
            {
                Console.WriteLine(queue2.Front());
                queue2.Pop();
            }
            Console.ReadKey();
        }
    }
}
