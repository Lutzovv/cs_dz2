using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Figure5
    {
        public static double S(double a)
        {
            return a * a;
        }

        public static double S(double a, double b)
        {
            return a * b;
        }

        public static double S(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }
    }
}
