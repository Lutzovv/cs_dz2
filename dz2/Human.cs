using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Human
    {
        //ФИО, пол, возраст, цвет глаз
        private string _FIO;
        private string _sex;
        private int _age;
        private string _eyeColor;

        Human(string fIO, string sex, string age, string eyeColor)
        {
            _FIO = fIO;
            _sex = sex;
            _age = age;
            _eyeColor = eyeColor;
        }

        public static string operator+(Human a, Human b)
        {
            if ((a._eyeColor == "Голубые") || (b._eyeColor == "Голубые"))
            {
                return "Голубые";
            }
            else if ((a._eyeColor == "Карие") || (b._eyeColor == "Карие"))
            {
                return "Голубые";
            }
            return a._eyeColor;
        }

        public static bool operator >(Human a, int b)
        {
            return a._age > b;
        }
        public static bool operator <(Human a, int b)
        {
            return a._age < b;
        }
    }
}
