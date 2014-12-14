using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCoreLib
{
   public class Student
    {
        public byte[] Photo
        {
            set;
            get;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            set;
            get;
        }

        public string Department
        {
            set;
            get;
        }

        public Sex Sex
        {
            set;
            get;
        }
        public Level CurrentLevel
        {
            set;
            get;
        }
        public ModeOfEntry ModeOfEntry
        {
            set;
            get;
        }

        public override string ToString()
        {
            return "STUDENT NAME: " + FirstName + " " + LastName + "\nSEX: " + Sex.ToString() +
           "\nDEPARTMENT: " + Department + "\nCURRENT LEVEL: " + CurrentLevel.ToString() + "\nMODE OF ENTRY: " + ModeOfEntry.ToString();
        }
    }
}
