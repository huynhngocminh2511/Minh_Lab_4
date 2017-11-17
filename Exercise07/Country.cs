using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Country : ICompare<Country>
    {
        public string Name { set; get; }
        public string Area { set; get; }

        public Country(string Name, string Area)
        {
            this.Name = Name;
            this.Area = Area;
        }

        public override string ToString()
        {
            return Name + " " + Area;
        }

        public bool IsBigger(Country cou)
        {
            return (Name.CompareTo(cou.Name) >= 0);
        }
    }
}
