using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathGrad.models
{
    class track
    {
        public static string courseType { get; set; }
        public static List <Course> studentTrack { get; set; } // this is making a list of courses. 
        public static string calcHours { get; set; }
        public static string expectedGrad { get; set; }
        public static float calcGPA { get; set; }
    }
}
