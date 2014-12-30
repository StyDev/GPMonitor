using PhoneCoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GPLogic
    {
        public float CalculateGP(List<Course> courses, out float course_weight, out float TotalUnit)
        {                    
            course_weight = 0;  //
            TotalUnit = 0;            

            foreach (Course thecourse in courses)
            {
                course_weight += (int)thecourse.courseGrade * thecourse.courseUnit;
                TotalUnit += thecourse.courseUnit;                
            }
            return course_weight / TotalUnit;

        }
    }
}
