using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Figure4
    {
        private const double PI = 3.14;

        public static double S(double r, double h)
        {
            return 2 * PI * r * (r + h);
        }

        public static double S(double r)
        {
            return 4 * PI * (r * r);
        }
    }
}
