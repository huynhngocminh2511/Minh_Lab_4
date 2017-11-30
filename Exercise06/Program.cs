using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Top());
                stack.Pop();
            }
            var stack2 = new Stack<string>();
            stack2.Add("a");
            stack2.Add("b");
            stack2.Add("c");
            while (!stack2.IsEmpty())
            {
                Console.WriteLine(stack2.Top());
                stack2.Pop();
            }
            Console.ReadKey();
        }
    }
}
