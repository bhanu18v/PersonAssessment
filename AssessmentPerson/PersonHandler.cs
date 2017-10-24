using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class PersonHandler
    {
        public void SetAge (Person pers, int age)
        {
            //pers.Age = age;
        }
        public Person CreatePerson(int iAge, string fName, string lName, float Height, float Weight)
        {
            Person OnePer = new Person();
            OnePer.Age = iAge;
            OnePer.Fname = fName;
            OnePer.Lname = lName;
            OnePer.Height = Height;
            OnePer.Weight = Weight;

            return OnePer;

        }
    }
   
    
}
