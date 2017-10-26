using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class BirdSubClass : AnimalsInheritance
    {
        private float birdWingsSpan;

        public float BirdsWingsSpan
        {
            get { return birdWingsSpan; }
            set { birdWingsSpan = value; }
        }
        /****----adding new property------****/

        private float flyHeight;

        public float FlyHeight
        {
            get { return flyHeight; }
            set { flyHeight=value; }
        }
        public BirdSubClass()
        {
            
        }

    }
}
