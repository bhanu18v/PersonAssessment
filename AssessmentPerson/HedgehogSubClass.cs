using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class HedgehogSubClass : AnimalsInheritance
    {
        private int numberOfSpikes;

        public int NumberOfSpikes
        {
            get { return numberOfSpikes; }
            set { numberOfSpikes = value; }
        }


    }
}
