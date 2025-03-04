using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Investing
    {
        private static string _FIO;
        private static double _sum;
        private static double _bid;

        Investing(string FIO, double sum, double bid)
        {
            _FIO = FIO;
            _sum = sum;
            _bid = bid;
        }

        public static double getBid()
        {
            return _bid;
        }

        public static Investing operator ++(Investing obj)
        {
            _sum += (_bid * 100 / _sum);
            return obj;
        }

        public static Investing operator --(Investing obj)
        {
            _sum += (_bid * 100 / _sum);
            return obj;
        }
    }
}
