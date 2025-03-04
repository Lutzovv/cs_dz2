using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Figure3
    {
        public static double S(double a)
        {
            return 6 * (a * a);
        }

        public static double S(double a, double b, double c)
        {
            return 2 * (a * b + a * c + b * c);
        }
    }
}
