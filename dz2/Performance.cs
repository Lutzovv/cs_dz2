using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Performance
    {
        private static int _min = 17;
        private static int _max = 70;

        public static bool IsPerformance(Human obj)
        {
            return ((obj > _min) && (obj < _max));
        }
    }
}
