using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    public class Person
    {
        private string fname;
        private string lname; 
        private int age;
        private float height;
        private float weight;
       

        // Declare a Name property of type string:
        public string Fname
        {
            get{return fname;}
            set{fname = value;}
        }

        // Declare an Age property of type int:
        public int Age
        {
            get{ return age;}
            set{age = value;}
        }
      

        public string Lname
        {
            get { return this.lname; }
            set { this.lname = value; }
        }

       

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }



        public override string ToString()
        {
            return "fName=  " + Fname + ", lName=  " + Lname + ", Age = " + Age + ", Weight=  " + weight + ", Height=  " + height;
        }

    }
}
