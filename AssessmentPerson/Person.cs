using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private float height;
        private float weight;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Fname
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public string Lname
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public float Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public float Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}
