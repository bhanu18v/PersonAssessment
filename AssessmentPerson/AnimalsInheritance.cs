using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
   public class AnimalsInheritance
    {
        public AnimalsInheritance()
        {

        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private float weight;
        public float Weight
        {
            get { return weight; }
            set { weight = value; }

        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /************-----------Adding new property for animal----------************/

        private bool life;

        public bool Life
        {
            get { return life; }
            set { life = value; }
        }

        public virtual string Stats()
        {


            return Name + Age + Weight;
        }


    }
}





