using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class Swan:Bird
    {
        private int FlightHeight;

        public int flightheight
        {
            get { return FlightHeight; }
            set { FlightHeight = value; }
        }
        public Swan()
        {


        }


        public Swan(string name, int weight, int age, int wingwidth, int flightheight) :base(name,weight,age, wingwidth)
        {
            FlightHeight = flightheight;
        }
    }
}
