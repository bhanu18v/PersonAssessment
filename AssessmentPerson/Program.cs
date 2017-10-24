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
            Console.WriteLine("hi");

            // var e1 = new Employee("Jane");
            //e1.Salary = 25000;
            //var e2 = new Employee("Anne");
            //e2.Salary = 23000;

            //var person = new Person();
            //person.age = 22;
            //Console.WriteLine("Person Details are - {0}" , person);
            //Console.ReadLine();

            Person person = new Person();

            // Print out the name and the age associated with the person:
            Console.WriteLine("Person details - {0}", person);

            // Set some values on the person object:
            person.Name = "Joe";
            person.Age = 99;
            Console.WriteLine("Person details - {0}", person);

            // Increment the Age property:
            person.Age += 1;
            Console.WriteLine("Person details - {0}", person);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
