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

            Person person1 = new Person();
            Console.WriteLine("Enter your First Name:");
            person1.Fname= Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            person1.Lname = Console.ReadLine();

            Console.WriteLine("Hi"+" "+person1.Fname + " "+person1.Lname);

            Console.WriteLine("Enter your age:");
            Person pAge = new Person();
            PersonHandler newage = new PersonHandler();
            newage.SetAge(pAge, 25);
            Console.WriteLine(pAge.Age);
            //string sAge = Console.ReadLine();
            //int iAge = person1.Age;
            //if(!int.TryParse(sAge, out iAge))
            //{
            //    Console.WriteLine("Invalid Age");
            //}

            Console.WriteLine("How tall are you:");
            person1.Height =float.Parse( Console.ReadLine());

            Console.WriteLine("How much do you weigh:");
            person1.Weight = float.Parse(Console.ReadLine());


           
            
        }
    }
}
