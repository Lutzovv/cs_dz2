using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class College
    {
        private string _CollegeName;
        private int _StudentCount;
        private int _AudiencesCount;
        private int _TeachersCount;

        College(string collegeName, int studentCount, int audiencesCount, int teachersCount)
        {
            _CollegeName = collegeName;
            _StudentCount = studentCount;
            _AudiencesCount = audiencesCount;
            _TeachersCount = teachersCount;
        }

        public int GetStudentCount() => _StudentCount;
        public int GetTeachersCount() => _TeachersCount;
        public static bool operator>(College a, College b)
        {
            if (a._StudentCount == b._StudentCount)
            {
                return a._AudiencesCount > b._AudiencesCount;
            }
            else
            {
                return a._StudentCount > b._StudentCount;
            }
        }

        public static bool operator <(College a, College b)
        {
            if (a._StudentCount == b._StudentCount)
            {
                return a._AudiencesCount < b._AudiencesCount;
            }
            else
            {
                return a._StudentCount < b._StudentCount;
            }
        }
    }
}
