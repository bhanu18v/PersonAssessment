using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class PersonHandler
    {

        public void setAge(Person pers,int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age,string fname,string lname,float height,float weight)
        {
            Person person1 = new Person();
            person1.Age = age;
            person1.Fname = fname;
            person1.Lname = lname;
            person1.Height = height;
            person1.Weight = weight;
            
            
            return  person1;
        }

        public string PrintPerson(Person p)
        {
            return "fName=  " + p.Fname + ", lName=  " + p.Lname + ", Age = " + p.Age + ", Weight=  " + p.Weight + ", Height=  " + p.Height;
        }
    }
}
