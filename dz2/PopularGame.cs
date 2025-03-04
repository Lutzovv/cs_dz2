using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class PopularGame
    {
        private static double _rating = 8.5;
        private static int _AveragePlayers = 1000;
        private static int _MaxPlayers = 1000;

        public static bool IsPopular(Game obj)
        {
            if (obj >= _rating)
            {
                if (!(obj < _AveragePlayers))
                {
                    if (obj >= _AveragePlayers)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
