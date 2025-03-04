using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Empire
    {
        private static int _population = 300000;
        private static double _area = 900000;

        public static string IsEmpire(Nation obj)
        {
            return ((obj >= _population) && (obj >= _area)) ? "Это государство – империя" : "Это государство – не империя";
        }
    }
}
