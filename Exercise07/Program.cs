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

            list.ForEach(Console.WriteLine);

            StartSort(list);

            list.ForEach(Console.WriteLine);

            var list1 = new List<Country>();
            list1.Add(new Country("c", "a"));
            list1.Add(new Country("b", "b"));
            list1.Add(new Country("a", "c"));

            list1.ForEach(Console.WriteLine);

            StartSort(list1);

            list1.ForEach(Console.WriteLine);

            var list2 = new List<Triangle>();
            list2.Add(new Triangle(3, 4, 5));
            list2.Add(new Triangle(2, 3, 4));
            list2.Add(new Triangle(1, 2, 3));

            list2.ForEach(Console.WriteLine);

            StartSort(list2);

            list2.ForEach(Console.WriteLine);

            Console.ReadKey();
        }

        public static void StartSort<T>(List<T> list) where T : ICompare<T>
        {
            for (int i = 0; i <= list.Count - 2; i++)
            {
                for (int j = i + 1; j <= list.Count - 1; j++)
                {
                    if (list[i].IsBigger(list[j]))
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
