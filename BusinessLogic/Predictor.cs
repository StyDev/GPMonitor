using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Predictor
    {
        public double newobtainable; //field
        public double Target; //field
        int NumberOfAssessments;
        double AssessmentObtainable;
        double SumAssessmentObtainable;
        double SumAssessmentObtained;
        string Inpu;
        string Input;
        double target;
        double AssessmentObtained;

        public void Quest(ref double SumAssessmentObtained, ref double sumAssessmentObtainable, ref double AssessmentObtainable)
        {
            //int test_num =0,sumAssessmentObtainable =0,obtainable=0;
            Console.WriteLine("Input your C/A score");
            int firstScore = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} out of?", firstScore);
            int firstOver = Int32.Parse(Console.ReadLine());
            SumAssessmentObtained += firstScore;
            sumAssessmentObtainable += firstOver;
            AssessmentObtainable -= firstOver;
            double scorestotarget = target - SumAssessmentObtained;
            Console.WriteLine("Press 1 to input more C/A");
            int inputs = Int32.Parse(Console.ReadLine());
            if (inputs == 1) { Quest(ref SumAssessmentObtained, ref sumAssessmentObtainable, ref AssessmentObtainable); }

        }
        public void Meettarget(ref int AssessmentObtainable, ref int scorestotarget)
        {
            int margin = scorestotarget - AssessmentObtainable;
            if (margin <= 0)
            {
                Console.WriteLine("You can still meet target");
            }
            else if (margin > 0)
            {
                Console.WriteLine("You can no longer meet target! \n Please press 1 to find out suggestions");
                int suggest = int.Parse(Console.ReadLine());
                if (suggest == 1) { Suggestions(); }
            }

        }
        public void Suggestions()
        {


        }


        public double GradetoScore()
        {
            Console.WriteLine("What grade would you like to have?");
            Input = (Console.ReadLine()).ToUpper();
            target = 0;


            switch (Input)
            {
                case "A":
                    Console.WriteLine("You need at least 70 to Make an A");
                    target = 70;
                    break;
                case "B":
                    Console.WriteLine("You need at least 60 to make a B");
                    target = 60;
                    break;
                case "C":
                    Console.WriteLine("You need at least 50 to make a C");
                    target = 50;
                    break;
                case "D":
                    Console.WriteLine("You need at least 45 to make a D");
                    target = 45;
                    break;
                case "E":
                    Console.WriteLine("You need at least 40 to make an E");
                    target = 40;
                    break;
                case "F":
                    Console.WriteLine("F can't be your goal, can it? You need at Most 39 to make an F");
                    target = 39;
                    break;
                default:
                    Console.WriteLine("Enter a new grade! A,B,C,D,E or F");
                    break;
            }

            return (target);
        }
    }
}
