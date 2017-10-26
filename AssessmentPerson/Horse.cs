using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    public class Horse:Animal
    {
        public int height
        {
            get { return Height; }
            set { Height = value; }
        }
        private int Height;

        public Horse()
        {

        }

        public Horse(string name,int weight,int age,int height): base(name,weight,age)
        {
                  Height = height;
         }
        public override string Stats()
        {
            return base.Stats() + " " + "Height: " + height;
        }

    }
}
