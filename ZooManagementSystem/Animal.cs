using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    internal abstract class Animal : IAnimal
    {
        private string name;
        private int age;
        private string species;
        public virtual void DisplayInfo()
        {
            Console.WriteLine("I am from the Abstract Animal Class");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("WooooHooooooooo From Animal Abstract Class");
        }

        public abstract void Eat();

        public abstract void Sleep();

        public abstract void Move();

        public string Name { 
            get => name; 
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Species
        {
            get => species;
            set => species = value;
        }

    }
}
