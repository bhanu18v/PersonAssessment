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

            /***-----commenting to check other functionalities----------

                        Console.WriteLine("Enter your First Name:");
                        string sName = Console.ReadLine();
                        Console.WriteLine("Enter your Last Name:");
                        string lName = Console.ReadLine();
                        Console.WriteLine("Enter your age:");
                        int intAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("How tall are you:");
                        float height = float.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you weigh:");
                        float weight = float.Parse(Console.ReadLine() + "\n" + "\n");
                        Person AddPrson = new Person();
                        PersonHandler newPerson1 = new PersonHandler();
                        AddPrson = newPerson1.CreatePerson(intAge, sName, lName, height, weight);


                        //Printing the output

                        Console.WriteLine("=================================================================");

                        Console.Write("Hi" + " " + sName + " " + lName + "\n");
                        Console.Write("Your age is : " + intAge + "\n");
                        Console.Write("Your Weight is : " + weight + "\n");
                        Console.Write("Your Height is  : " + height + "\n");

                        Console.ReadLine();


                ----------------------------------------------------*/

            MainClassforInheritance inheritance = new MainClassforInheritance();
            inheritance.mainmenu();
        }


        }
    }



