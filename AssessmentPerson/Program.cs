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


            PersonHandler newclass = new PersonHandler();
            newclass.check();

            //OLD CODE
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
