using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = 5;
            Console.WriteLine($"{q} is prime? " + q.IsPrime());
            q = 7;
            Console.WriteLine($"{q} is prime? " + q.IsPrime());
            q = 9;
            Console.WriteLine($"{q} is prime? " + q.IsPrime());
            q = 10;
            Console.WriteLine($"{q} is prime? " + q.IsPrime());
            Console.ReadKey();
        }
    }

    public static class IntExtension
    {
        public static bool IsPrime(this int q)
        {
            var n = (int)Math.Sqrt(q);
            for (int i = 2; i <= n; i++)
            {
                if (q % i == 0) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
