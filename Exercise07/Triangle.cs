using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Triangle : ICompare<Triangle>
    {
        public int A { set; get; }
        public int B { set; get; }
        public int C { set; get; }

        public Triangle(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

        public double GetArea()
        {
            var p = GetPerimeter() / 2.0;
            var area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }

        public bool IsBigger(Triangle tri)
        {
            return GetArea() > tri.GetArea();
        }

        public override string ToString()
        {
            return $"A: {A} B: {B} C: {C}";
        }
    }
}
