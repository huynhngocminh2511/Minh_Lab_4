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
            var st = new Stack<int>();
            st.Add(1);
            st.Add(2);
            st.Add(3);
            while (!st.Isempty())
            {
                Console.WriteLine(st.Top());
                st.Pop();
            }
            var st2 = new Stack<string>();
            st2.Add("a");
            st2.Add("b");
            st2.Add("c");
            while (!st2.Isempty())
            {
                Console.WriteLine(st2.Top());
                st2.Pop();
            }
            Console.ReadKey();
        }
    }
}
