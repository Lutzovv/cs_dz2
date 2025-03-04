using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Numbers
    {
        public static int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int FindMax(int a, int b, int c) { return FindMax(a, FindMax(b, c)); }
        public static int FindMax(int a, int b, int c, int d) { return FindMax(FindMax(a, b), FindMax(c, d)); }
    }
}
