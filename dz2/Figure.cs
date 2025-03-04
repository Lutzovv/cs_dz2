using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Figure
    {

        public static double V(double x) 
        {
            return x * x * x;
        }

        public static double V(double x, double y, double z) 
        {
            return x * y * z;
        }

    }
}
