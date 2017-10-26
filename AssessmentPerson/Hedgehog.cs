using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
   public class Hedgehog:Animal
    {
        private int Strength;

        public int strength
        {
            get { return Strength; }
            set { Strength = value; }
        }

        public Hedgehog()
        {

        }

        public Hedgehog(string name,int weight,int age, int strength):base (name,weight,age)
        {

            Strength = strength;

        }

    }
}
