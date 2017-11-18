using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Extension method exercise";
            Console.WriteLine(str.WordCount());
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }
    }
}
