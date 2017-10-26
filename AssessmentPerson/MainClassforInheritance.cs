using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPerson
{
    class MainClassforInheritance
    {
        public void mainmenu()
        {
            AnimalsInheritance animal = new AnimalsInheritance();
            //Console.WriteLine("Passing values to Animal properties "+ "\n Base animal name :"+ animal.Name+","+"\n Base animal age :"+animal.Age+","+"\n Base animal weight : "+animal.Weight);
       
                var animals = new List<AnimalsInheritance>
        {
            new HorseSubClass(),
            new DogSubClass(),
            new BirdSubClass(),
            new HedgehogSubClass( )
        };
            
                foreach (var varanimal in animals)
                {
                varanimal.Stats();


                }

                // Keep the 











            }


        }
}
