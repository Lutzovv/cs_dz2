using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Array
    {
        public static int ArithmeticMean(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }

            return sum / arr.Length;
        }

        public static double ArithmeticMean(double[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }

            return sum / arr.Length;
        }
    }
}
