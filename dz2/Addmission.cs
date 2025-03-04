using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    internal class Addmission
    {
        private static double min = 4.5;

        public static bool IsAccept(Student student)
        {
            return student > min;
        }


    }
}
