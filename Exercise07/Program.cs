using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Student>();
            list.Add(new Student("a", new DateTime(1117, 11, 11), 9));
            list.Add(new Student("b", new DateTime(1118, 11, 11), 8));
            list.Add(new Student("c", new DateTime(1119, 11, 11), 7));

            foreach (var i in list)
            {
                Console.WriteLine($"{i}");
            }

            StartSort(list);
            
            foreach (var i in list)
            {
                Console.WriteLine($"{i}");
            }

            var list1 = new List<Country>();
            list1.Add(new Country("c", "a"));
            list1.Add(new Country("b", "b"));
            list1.Add(new Country("a", "c"));

            foreach (var i in list1)
            {
                Console.WriteLine($"{i}");
            }

            StartSort(list1);

            foreach (var i in list1)
            {
                Console.WriteLine($"{i}");
            }

            var list2 = new List<Triangle>();
            list2.Add(new Triangle(3, 4, 5));
            list2.Add(new Triangle(2, 3, 4));
            list2.Add(new Triangle(1, 2, 3));

            foreach (var i in list2)
            {
                Console.WriteLine($"{i}");
            }

            StartSort(list2);

            foreach (var i in list2)
            {
                Console.WriteLine($"{i}");
            }

            Console.ReadKey();
        }

        public static void StartSort<T>(List<T> list)
        {
            for (int i = 0; i <= list.Count - 2; i++)
            {
                for (int j = i + 1; j <= list.Count - 1; j++)
                {
                    var obj = list[i] as ICompare<T>;
                    if (obj.IsBigger(list[j]))
                    {
                        Swap(ref list, i, j);
                    }
                }
            }
        }

        public static void Swap<T>(ref List<T> list, int q, int w)
        {
            var t = list[q];
            list[q] = list[w];
            list[w] = t;
        }
    }
}
