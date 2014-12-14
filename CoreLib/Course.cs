
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class Course
    {
        public string courseTitle;
        public string courseCode;
        public int courseUnit;
        public Grade courseGrade;
        public string lecturer;
        public string suggestions;
        public float score;

        public float CourseWeight
        {
            get { return (int)courseGrade * courseUnit; }
        }

        public string CourseTitle
        {
            get
            { return courseTitle; }
            set
            { courseTitle = value; }
        }

        public float Score
        {
            get
            { return score; }
            set
            {
                score = value;
                if (score >= 70)
                {
                    courseGrade = Grade.A;
                }
                else if (score >= 60)
                {
                    courseGrade = Grade.B;
                }
                else if (score >= 50)
                {
                    courseGrade = Grade.C;
                }
                else if (score >= 45)
                {
                    courseGrade = Grade.D;
                }
                else if (score >= 40)
                {
                    courseGrade = Grade.E;
                }
                else if (score < 40)
                {
                    courseGrade = Grade.F;
                }
            }
        }
        
        public string CourseCode
        {
            get
            { return courseCode; }
            set
            { courseCode = value; }
        }

        public Grade CourseGrade
        {
            get
            { return courseGrade; }
            set
            { courseGrade = value; }
        }
        public int CourseUnit
        {
            get
            { return courseUnit; }
            set
            { courseUnit = value; }
        }
        public string Lecturer
        {
            get
            { return lecturer; }
            set
            { lecturer = value; }
        }

        public string Suggestions
        {
            get
            { return suggestions; }
            set
            { suggestions = value; }
        }
        public override string ToString()
        {
            return "COURSE TITLE: " + courseTitle + "\nCOURSE CODE: " + courseCode + "\nLECTURER: " + lecturer + "\nNUMBER OF UNITS: " + courseUnit;
        }

    }
}
