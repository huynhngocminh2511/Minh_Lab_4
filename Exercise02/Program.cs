using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "heLlO";
            Console.WriteLine(str.CaptionFirst());
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static string CaptionFirst(this string str)
        {
            var firststr = str[0].ToString();
            firststr = firststr.ToUpper();
            var secondnstr = str.Substring(1);
            secondnstr = secondnstr.ToLower();
            return firststr + secondnstr;
        }
    }
}
