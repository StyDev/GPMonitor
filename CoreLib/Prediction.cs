using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediction
{
    public class Prediction
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


        public double scoreToTarget() //method
        {
            Console.WriteLine("What grade would you like to have?");
            Inpu = Console.ReadLine();
            Input = Inpu.ToUpper();

            target = 0;



            switch (Input)
            {
                case "A":
                    Console.WriteLine("You need at least 70 to Make an A");
                    target = 70;
                    break;
                case "B":
                    Console.WriteLine("You need at least 60 to Make an B");
                    target = 60;
                    break;
                case "C":
                    Console.WriteLine("You need at least 50 to Make an C");
                    target = 50;
                    break;
                case "D":
                    Console.WriteLine("You need at least 40 to Make an D");
                    target = 40;
                    break;
                case "E":
                    Console.WriteLine("You need at least 45 to Make an E");
                    target = 45;
                    break;
                case "F":
                    Console.WriteLine("You need at least 39 to Make an F");
                    target = 40;
                    break;
                default:
                    Console.WriteLine("Enter a new grade! A,B,C,D,E or F");
                    break;
            }

            return (target);
        }

        public double newObtainable() //method
        {
            Console.WriteLine("How many Assessments did you have this semester?");
            NumberOfAssessments = int.Parse(Console.ReadLine());

            newobtainable = 100;
            SumAssessmentObtainable = 0;
            Target = target;
            SumAssessmentObtained = 0;

            for (int i = 1; i <= NumberOfAssessments; i++)
            {
            EnterAssessment:
                Console.WriteLine("Enter the Maximum obtainable marks in Assessment {0}", i);
                AssessmentObtainable = double.Parse(Console.ReadLine());

                newobtainable = newobtainable - AssessmentObtainable;
                SumAssessmentObtainable = SumAssessmentObtainable + AssessmentObtainable;


                Console.WriteLine("You still have {0} marks Obtainable:", newobtainable);


                Console.WriteLine("What did you score in Assessment {0} out of {1} Marks Obtainable", i, AssessmentObtainable);
                AssessmentObtained = double.Parse(Console.ReadLine());
                SumAssessmentObtained = SumAssessmentObtained + AssessmentObtained;

                if (AssessmentObtained > AssessmentObtainable)
                {
                    Console.WriteLine("Enter a value below {0}", AssessmentObtainable);
                    goto EnterAssessment;
                }

                Target = Target - AssessmentObtained;
                Console.WriteLine("You need {0} more marks to get {1}", Target, Input);

            }

            Console.WriteLine("Total marks Obtainable in all assessments: {0}", SumAssessmentObtainable);
            Console.WriteLine("Total marks Obtained in all assessments: {0}", SumAssessmentObtained);
            return (newobtainable);
        }

        public void DegreeOfCloseness()
        {

            if (newobtainable - Target <= 0)
            {
                Console.WriteLine("It may be difficult to get a {0}", Input);
            }
            return;
        }

        public override string ToString()
        {
            return ("PREDICTED GRADE: " + Input + "\nTOTAL NUMBER OF ASSESSMENTS: " + NumberOfAssessments +
               "\nTOTAL OBTAINED POINTS: " + SumAssessmentObtained +
               "\nTOTAL OBTAINABLE POINTS IN THE ASSESSMENT: " + SumAssessmentObtainable +
            "\nPOINTS REMAINING TO MEET TARGET: " + Target +
           "\nPOINTS OBTAINABLE IN THE EXAM: " + newobtainable);
        }
    }
}