using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class DogSubClass : AnimalsInheritance
    {
        private string bark;

        public string Bark
        {
            get { return bark; }
            set { bark = value; }
        }
        public DogSubClass()
        {

        }

        public DogSubClass(string name, int weight, int age, string bark):base()
        {
            Bark = bark; 
        }
    }
}

