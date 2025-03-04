using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Nation
    {
        private string _name;
        private int _population;
        private double _area;

        Nation(string name, int population, double area)
        {
            _name = name;
            _population = population;
            _area = area;
        }

        public static bool operator >(Nation a, Nation b)
        {
            if (a._population != b._population)
            {
                return a._population > b._population;
            }
            else
            {
                return a._area > b._area;
            }
        }
        public static bool operator <(Nation a, Nation b)
        {
            return b > a;
        }
        public static bool operator >=(Nation a, int b)
        {
            return a._population >= b;
        }
        public static bool operator <=(Nation a, int b)
        {
            return a._population < b;
        }
        public static bool operator >=(Nation a, double b)
        {
            return a._area >= b;
        }
        public static bool operator <=(Nation a, double b)
        {
            return a._area < b;
        }

    }
}
