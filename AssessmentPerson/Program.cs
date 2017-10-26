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

            //Console.WriteLine("Enter your First Name:");
            //string sName = Console.ReadLine();
            //Console.WriteLine("Enter your Last Name:");
            //string lName = Console.ReadLine();
            //Console.WriteLine("Enter your age:");
            //int intAge = int.Parse(Console.ReadLine());
            //Console.WriteLine("How tall are you:");
            //float height = float.Parse(Console.ReadLine());
            //Console.WriteLine("How much do you weigh:");
            //float weight = float.Parse(Console.ReadLine() + "\n" + "\n");
            //Person AddPrson = new Person();
            //PersonHandler newPerson1 = new PersonHandler();
            //AddPrson = newPerson1.CreatePerson(intAge, sName, lName, height, weight);

            ////Printing the output
             
            //Console.WriteLine("=================================================================");

            //Console.Write("Hi" + " " + sName + " " + lName + "\n");
            //Console.Write("Your age is : " + intAge + "\n");
            //Console.Write("Your Weight is : " + weight + "\n");
            //Console.Write("Your Height is  : " + height + "\n");

            //Console.ReadLine();

            Horse horse = new Horse("bhanu", 80, 22, 12);
            Console.WriteLine(" printing race " + horse.Stats());
            Console.ReadLine();

            List<Animal> animals = new List<Animal>();
            Horse horse1 = new Horse("Horse", 20, 22, 12);
            Dog dog1 = new Dog("Dog", 11, 2, "brown color dog");
            Hedgehog hedgehog1 = new Hedgehog("Spikes Hedgehog", 22, 3, 34);
            Bird bird1 = new Bird("Beautiful bird", 12, 2, 6);
            animals.Add(horse1);
            animals.Add(dog1);
            animals.Add(hedgehog1);
            animals.Add(bird1);
            

            foreach (var tAnimals in animals)
            {
                //if(animals == dog1.GetType.dog1)

                Console.WriteLine(tAnimals.Stats());
                Console.ReadLine();
            }


            //foreach (var varanimal in animals)
            //{
            //    Console.WriteLine("Inside list------->" + varanimal.Stats());

            //}

            Dog nAnimal = new Dog();
            Console.WriteLine(  nAnimal.Speak());
            Console.ReadLine();





            //List < string > iList= new List<string>();
            //string aniAge = "30";
            //string aniWeight = "150";
            //Animal NewAnimalClass = new Animal();
            //NewAnimalClass.name = "Tiger";
            //NewAnimalClass.age =int.Parse(aniAge);
            //NewAnimalClass.weigth = int.Parse(aniWeight);


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
