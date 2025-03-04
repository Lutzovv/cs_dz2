using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Student
    {
        private string FIO;
        private double average;
        private double self;
        private string date;

        public static bool operator >(Student student, double min)
        {
            return student.average > min;
        }

        public static bool operator <(Student student, double min)
        {
            return student.average < min;
        }

        public Student(string fIO, double average, double self, string date)
        {
            FIO = fIO;
            this.average = average;
            this.self = self;
            this.date = date;
        }

        public static bool operator >(Student a, Student b)
        {
            if (a.average == b.average) { 
                return a.self > b.self;
            }
            return a.average > b.average;
        }

        public static bool operator <(Student a, Student b)
        {
            return !(a.average > b.average);
        }
    }
}
