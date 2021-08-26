using PDC6_MOD2_ACTIVITY01.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDC6_MOD2_ACTIVITY01.ViewModels
{
    class StudentInformationViewModel
    {
        public StudentInformation StudInfo { get; set; }

        public StudentInformationViewModel()
        {
            StudInfo = new StudentInformation
            {
                StudentID = 1,
                Name = "Marc Lester Z. Mallari",
                CourseCode = "PDC06",
                CourseTitle = "Xamarin Mobile Programming",
                NumberOfUnits = 3,
                DateOfAttendance = DateTime.Now,
            };
        }
    }
}
