using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class Pelican:Bird  
    {
        private int BeakLen;

        public int beaklen
        {
            get { return BeakLen; }
            set { BeakLen = value; }
        }
        public Pelican ()
        {


        }


        public Pelican (string name,int weight,int age, int wingwidth, int beaklen):base(name,weight,age,wingwidth)
        {

            BeakLen = beaklen;
        }

    }
}
