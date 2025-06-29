using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    internal class Lion : Animal, ICarnivore
    {

        public Lion()
        {
            Name = "No Name";
            Age = 0;
            Species = "No Species";

        }
        public Lion(string name = "No Name", int age = 0, string species = "No Species")
        {
            Name = name;
            Age = age;
            Species = species;
        }
        public override void Eat()
        {
            Console.WriteLine("Lion: Eats meat");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Lion: Roars");
        }

        public override void DisplayInfo()
        {
            //Console.WriteLine("Enter the name of the lion!");
            //string name = Console.ReadLine()!;
            //Console.WriteLine("Enter the age of the lion!");
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
            Console.WriteLine("I sleep from 12 to 5");
        }

        public override void Move()
        {
            Console.WriteLine("I move like i am hungry");
        }

        public void Hunt()
        {
            Console.WriteLine("I save trees dawwg");
        }

        public override string ToString()
        {
            return $"My Name is {Name} and My Age: {Age} and My Species {Species}";
        }
    }
}
