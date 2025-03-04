using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    internal class Credit
    {
        private string FIO;
        private double sum;
        private static double bid;

        Credit(string fIO, double sum)
        {
            FIO = fIO;
            this.sum = sum;
        }

        public static double operator -(Credit credit, double sum_i) {
            
           return credit.sum - sum_i;

        }
    }
}
