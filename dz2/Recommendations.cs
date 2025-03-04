using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Recommendations
    {
        public static bool IsRecommended(Post obj)
        {
            return obj >= obj * 2;
        }
    }
}
