using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter your First Name:");
            string sName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            string lName = Console.ReadLine();

            Console.WriteLine("Hi" + " " + sName + " " + lName);

            Console.WriteLine("Enter your age:");
            int intAge = int.Parse(Console.ReadLine());

            Console.WriteLine("How tall are you:");
            float height =float.Parse(Console.ReadLine());
            Console.WriteLine("How much do you weigh:");
            float weight = float.Parse(Console.ReadLine());

            PersonHandler newPerson1 = new PersonHandler();
            newPerson1.CreatePerson(intAge, sName, lName, height, weight);
            //Person person1 = new Person();
            
            //person1.Fname= Console.ReadLine();

            
            //person1.Lname = Console.ReadLine();

            


            //Person pAge = new Person();
            //PersonHandler newage = new PersonHandler();
            //newage.CreatePerson(intAge,);
            //Console.WriteLine(pAge.Age);
            //string sAge = Console.ReadLine();
            //int iAge = person1.Age;
            //if(!int.TryParse(sAge, out iAge))
            //{
            //    Console.WriteLine("Invalid Age");
            //}

            
            //person1.Height =float.Parse( Console.ReadLine());

           
            //person1.Weight = float.Parse(Console.ReadLine());


           
            
        }
    }
}
