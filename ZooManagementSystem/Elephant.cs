using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    internal class Elephant : Animal,IHerbivore
    {

        public Elephant()
        {
            Name = "No Name";
            Age = 0;
            Species = "No Species";

        }
        public Elephant(string name = "No Name", int age = 0, string species = "No Species")
        {
            Name = name;
            Age = age;
            Species = species;
        }
        public override void Eat()
        {
            Console.WriteLine("Elephant: Eats Plants");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Elephant: Trumpet");
        }

        public override void DisplayInfo()
        {
            //Console.WriteLine("Enter the name of the elephant!");
            //string name = Console.ReadLine()!;
            //Console.WriteLine("Enter the age of the elephant!");
            //int age = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("Enter what type of species your animal is: ");
            //string species = Console.ReadLine()!;

            //Name = name;
            //Age = age;
            //Species = species;

            Console.WriteLine($"Name: {Name}, Age: {Age}, Species: {Species}");
        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep from the 12 to 12");
        }

        public override void Move()
        {
            Console.WriteLine("I am not moving at all!");
        }

        public void Graze()
        {
            Console.WriteLine("I eat only plants dawwg do not look at me like this!");
        }
    }
}
