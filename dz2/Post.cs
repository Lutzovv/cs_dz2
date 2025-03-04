using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Post
    {
        private int _id;
        private int _likes;
        private int _dislikes;
        private string _text;

        Post(int id, int likes, int dislikes, string text)
        {
            _id = id;
            _likes = likes;
            _dislikes = dislikes;
            _text = text;
        }

        public static Post operator +(Post a, int b)
        {
            a._likes += b;
            return a;
        }
        public static Post operator -(Post a, int b)
        {
            a._dislikes += b;
            return a;
        }
        public static Post operator ++(Post a)
        {
            a._likes++;
            return a;
        }
        public static Post operator --(Post a)
        {
            a._dislikes++;
            return a;
        }
        public static int operator *(Post a, int b)
        {
            return a._dislikes * b;
        }
        public static bool operator >=(Post a, int b)
        {
            return a._likes >= b;
        }
        public static bool operator <=(Post a, int b)
        {
            return a._likes <= b;
        }
    }
}
