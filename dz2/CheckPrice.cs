using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class CheckPrice
    {
        private static double _LowPrice = 100;
        private static double _MediumPrice = 500;
        private static double _HighPrice = 1500;

        public static string Check(Ingredient ingredient)
        {
            if (ingredient < _LowPrice)
            {
                return "Цена очень низкая";
            }
            else if (ingredient >= _LowPrice && ingredient < _MediumPrice)
            {
                return "Цена низкая";
            }
            else if (ingredient >= _MediumPrice && ingredient < _HighPrice)
            {
                return "Цена завышена";
            }
            else
            {
                return "Цена слишком высокая";
            }
        }
    }
}
