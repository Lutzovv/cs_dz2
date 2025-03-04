using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Game2
    {
        private string _name;
        private int _AveragePlayers;
        private int _MaxPlayers;
        private double _rating;

        Game2(string name, int averagePlayers, int maxPlayers, double rating)
        {
            _name = name;
            _AveragePlayers = averagePlayers;
            _MaxPlayers = maxPlayers;
            _rating = rating;
        }

        public static bool operator >(Game2 a, Game2 b)
        {
            int countA = 0;
            int countB = 0;
            if (a._AveragePlayers > b._AveragePlayers) countA++;
            else countB++;
            if (a._MaxPlayers > b._MaxPlayers) countA++;
            else countB++;
            if (a._rating > b._rating) countA++;
            else countB++;
            return countA > countB;
        }

        public static bool operator < (Game2 a, Game2 b)
        {
            return b > a;
        }

        public static bool operator ==(Game2 a, Game2 b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Game2 a, Game2 b)
        {
            return !a.Equals(b);
        }
    }
}
