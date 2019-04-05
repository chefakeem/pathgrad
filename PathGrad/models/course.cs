using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathGrad.models
{
    class Course
    {
        public static string courseNumber { get; set; }
        public static string courseName { get; set; }
        public static string courseCreditHour { get; set; }
        public static string preReq { get; set; }
        public static string CourseType { get; set; }
        public static bool assignTaken { get; set; } = false;
    }


}