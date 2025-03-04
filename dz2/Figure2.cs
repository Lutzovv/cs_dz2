using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Figure2
    {
        private const double PI = 3.14;
        public static double V(int r, int h)
        {
            return PI * (r * r) * h;
        }

        public static double V(int r)
        {
            return (4 / 3) * (PI * (r * r * r));
        }
    }
}
