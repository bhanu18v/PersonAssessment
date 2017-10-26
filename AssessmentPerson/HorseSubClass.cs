using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class HorseSubClass : AnimalsInheritance
    {
        private float horseSpeed;

        public float HorseSpeed
        {
            get { return horseSpeed; }
            set { horseSpeed = value; }
        }

        public override string Stats()
        {
            return HorseSpeed.ToString();
        }


    }
}
