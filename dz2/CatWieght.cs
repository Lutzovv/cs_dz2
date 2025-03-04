using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class CatWieght
    {
        private static int small = 1;
        private static int middle = 3;
        private static int big = 5;

        public static string CheckCatWieght(Cat cat)
        {
            if (cat <= small)
            {
                return "Котик очень худой";
            }
            else if ((cat > small) && (cat <= middle))
            {
                return "Котик худой";
            }
            else if ((cat > middle) && (cat <= big))
            {
                return "Котик полноват";
            }
            else
            {
                return "Котик полный";
            }
        }
    }
}
