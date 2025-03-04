using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Game
    {
        private string _name;
        private int _AveragePlayers;
        private int _MaxPlayers;
        private double _rating;

        Game(string name, int averagePlayers, int maxPlayers, double rating)
        {
            _name = name;
            _AveragePlayers = averagePlayers;
            _MaxPlayers = maxPlayers;
            _rating = rating;
        }

        public static Game operator ++(Game obj)
        {
            if (obj._rating < 10.0)
            {
                obj._rating += 0.1;
            }
            return obj;
        }
        public static Game operator --(Game obj)
        {
            if (obj._rating > 0.0)
            {
                obj._rating -= 0.1;
            }
            return obj;
        }

        public static bool operator >(Game a, int b)
        {
            return a._AveragePlayers >= b;
        }
        public static bool operator <(Game a, int b)
        {
            return a._AveragePlayers >= b;
        }
        public static bool operator >=(Game a, int b)
        {
            return a._MaxPlayers >= b;
        }
        public static bool operator <=(Game a, int b)
        {
            return a._MaxPlayers <= b;
        }
        public static bool operator >=(Game a, double b)
        {
            return a._rating >= b;
        }
        public static bool operator <=(Game a, double b)
        {
            return a._rating <= b;
        }
    }
}
