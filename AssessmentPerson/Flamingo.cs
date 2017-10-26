using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class Flamingo:Bird
    {
        private int Leglen;

        public int leglen
        {
            get { return Leglen; }
            set { Leglen = value; }
        }
        public Flamingo()
        {


        }


        public Flamingo(string name, int weight, int age, int wingwidth, int leglen ):base(name,weight,age,wingwidth)
        {

            Leglen = leglen;
        }

    }
}
