using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCoreLib
{
    public class School
    {

        public string schoolName;
        public double maxAttainableGP;

        public string SchoolName
        {
            get
            { return schoolName; }
            set
            { schoolName = value; }
        }

        public double MaxAttainableGP
        {
            get
            { return maxAttainableGP; }
            set
            { maxAttainableGP = value; }
        }


    }
}
