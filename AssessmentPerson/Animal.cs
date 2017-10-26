using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
   public class Animal

    {    
        private string  Name;
        private int Weight;
        private int Age;

        public string  name {get { return Name; } set { Name = value; }}
        public int weigth{get { return Weight; } set { Weight = value; }}
        public int age {get { return Age; }set { Age = value; }}


        public Animal()
        {

        }
        public Animal(string name,int weight,int age)
        {
            Name = name;
            Weight = weight;
            Age = age;

        }
    }
   
}
