using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    interface ICompare<in T>
    {
        bool IsBigger(T t);
    }
}
