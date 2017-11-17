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
            var qu = new Queue<int>();
            qu.Add(1);
            qu.Add(2);
            qu.Add(3);
            while (!qu.Isempty())
            {
                Console.WriteLine(qu.Front());
                qu.Pop();
            }
            var qu2 = new Queue<string>();
            qu2.Add("a");
            qu2.Add("b");
            qu2.Add("c");
            while (!qu2.Isempty())
            {
                Console.WriteLine(qu2.Front());
                qu2.Pop();
            }
            Console.ReadKey();
        }
    }
}
