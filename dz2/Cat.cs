using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Cat
    {
        private string _name;
        private string _breed;
        private string _DateOfBirth;
        private double _Wieght;

        Cat(string name, string breed, string dateOfBirth, double wieght)
        {
            _name = name;
            _breed = breed;
            _DateOfBirth = dateOfBirth;
            _Wieght = wieght;
        }

        public static bool operator>(Cat a, Cat b)
        {
            return a._Wieght > b._Wieght;
        }

        public static bool operator <(Cat a, Cat b)
        {
            return a._Wieght < b._Wieght;
        }

        public static bool operator >(Cat a, int b)
        {
            return a._Wieght > b;
        }

        public static bool operator <=(Cat a, int b)
        {
            return a._Wieght <= b;
        }

        public static bool operator >=(Cat a, int b)
        {
            return a._Wieght >= b;
        }

        public static bool operator <(Cat a, int b)
        {
            return a._Wieght < b;
        }

        public static string operator*(Cat a, Cat b)
        {
            return a._breed == b._breed ? "Селекция возможна" : "Селекция не возможна";
        }
    }
}
