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

            Console.WriteLine("FullName:" + " " + sName + " " + lName);

            Console.WriteLine("Enter your age:");
            int intAge = int.Parse(Console.ReadLine());

            Console.WriteLine("How tall are you:");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("How much do you weigh:");
            float weight = float.Parse(Console.ReadLine());

            Person addPerson = new Person();
            PersonHandler newPerson1 = new PersonHandler();
            addPerson = newPerson1.CreatePerson(intAge, sName, lName, height, weight);

            Console.WriteLine(newPerson1.PrintPerson(addPerson));
            Console.ReadLine();


            //Console.WriteLine("enter your deatils");
            //Console.WriteLine("your first name: ");
        
            //Person person = new Person();


            //Console.WriteLine("FirstName: ");
            //var fname = Console.ReadLine();
            //person.Fname = fname;
            //Console.WriteLine("LastName: ");
            //var lname = Console.ReadLine();
            //person.Lname = lname;
            //Console.WriteLine("age: ");
            //var age = int.Parse(Console.ReadLine());
            //person.Age = age;
            //Console.WriteLine("Weight: ");
            //var weight = float.Parse(Console.ReadLine());
            //person.Weight = weight;
            //Console.WriteLine("Height: ");
            //var height = float.Parse(Console.ReadLine());
            //person.Height = height;
            //Console.WriteLine("printing the values"+person);
            //Console.ReadLine();

        }


        }
    }



