using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    public class Dog:Animal
    {
        private string Color;

        public string color
        {
            get { return Color; }
            set { Color = value; }
        }

        public Dog ()
        {

        }

        public Dog(string name,int weight, int age, string color):base (name,weight,age)
        {
            Color = color;
        }

        public override string Speak()
        {
            return "woff";

        }
    }
}
