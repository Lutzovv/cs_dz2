using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Ingredient
    {
        private string _name;
        private string _effect;
        private double _price;

        public Ingredient(string name, string effect, double price)
        {
            _name = name;
            _effect = effect;
            _price = price;
        }
        public static bool operator >(Ingredient a, Ingredient b)
        {
            return a._price > b._price;
        }
        public static bool operator <(Ingredient a, Ingredient b)
        {
            return a._price < b._price;
        }
        public static bool operator >=(Ingredient a, Ingredient b)
        {
            return a._price >= b._price;
        }
        public static bool operator <=(Ingredient a, Ingredient b)
        {
            return a._price <= b._price;
        }
        public static Ingredient operator +(Ingredient a, Ingredient b)
        {
            return new Ingredient("Зелье", a._effect + " + " + b._effect, (a._price + b._price) * 3);
        }
        public static bool operator >(Ingredient a, double b)
        {
            return a._price > b;
        }
        public static bool operator <(Ingredient a, double b)
        {
            return a._price < b;
        }
        public static bool operator >=(Ingredient a, double b)
        {
            return a._price >= b;
        }
        public static bool operator <=(Ingredient a, double b)
        {
            return a._price <= b;
        }
    }
}
