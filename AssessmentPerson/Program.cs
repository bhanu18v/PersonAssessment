﻿using System;
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



            //Horse horse = new Horse("bhanu", 80, 22, 12);
            //Console.WriteLine(" printing race "+ horse.Stats());
            //Console.ReadLine();
/***********Creating Animal List *************/
            List<Animal> animals = new List<Animal>();
            Horse horse1 = new Horse("Horse",20,22,12);
            Dog dog1 = new Dog("Dog",11,2,"brown color dog");
            Hedgehog hedgehog1 = new Hedgehog("Spikes Hedgehog",22,3,34);
            Bird bird1 = new Bird("Beautiful bird",12,2,6);
            animals.Add(horse1);
            animals.Add(dog1);
            animals.Add(hedgehog1);
            animals.Add(bird1);
           

            foreach (var varanimal in animals)
            {
                Console.WriteLine("Inside list------->"+ varanimal.Stats());
                
            }
            Console.ReadLine();
            /*******Creating Dog List******************/
            //List<Dog> dog = new List<Dog>();
            //Horse horse2 = new Horse();
            //dog.Add(horse2);It will throw error...

            List<Animal> animalsobj = new List<Animal>();







        }
    }
}
