using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public static class Standart
    {
        private static int _students = 100;
        private static int _teachers = 10;

        public static bool FitsStandard(College college)
        {
            return ((college.GetStudentCount() >= _students) && (college.GetTeachersCount() >= _teachers));
        }
    }
}
