using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class Bird:Animal
    {
        private int WingWidth;

        public int wingwidth
        {
            get { return WingWidth; }
            set { WingWidth = value; }
        }

        public Bird()
        {


        }

        public Bird(string name,int weight,int age,int wingwidth):base (name,weight,age)
        {
            WingWidth = wingwidth;
        }
        public override string Stats()
        {
            return base.Stats() + " " + "Wingwidth: " + wingwidth;
        }

    }
}
