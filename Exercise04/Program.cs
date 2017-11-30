using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = 1;
            var w = 2;
            Console.WriteLine($"{q} {w}");
            Swap(ref q, ref w);
            Console.WriteLine($"swapped: {q} {w}");
            var a = "a";
            var b = "b";
            Console.WriteLine($"{a} {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"swapped: {a} {b}");
            Console.ReadKey();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = b;
            b = a;
            a = temp;
        }
    }
}
