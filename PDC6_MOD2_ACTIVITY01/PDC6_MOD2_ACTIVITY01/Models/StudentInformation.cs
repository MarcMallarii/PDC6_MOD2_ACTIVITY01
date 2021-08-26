using System;
using System.Collections.Generic;
using System.Text;

namespace PDC6_MOD2_ACTIVITY01.Models
{
    class StudentInformation
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int NumberOfUnits { get; set; }
        public DateTime DateOfAttendance { get; set; }
    }
}
