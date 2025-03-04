using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Integer
    {
        public static int multiply(int a, int b) => a * b + 2;
        public static uint multiply(uint a, uint b) => a * b + 1;
        public static long multiply(long a, long b) => a * b + 3;
        public static double multiply(double a, double b) => a * b + 0.1;
    }
}
