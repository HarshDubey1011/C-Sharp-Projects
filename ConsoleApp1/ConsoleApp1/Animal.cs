using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        private string name;
        protected string sound;

        protected AnimalIdInfo animeIdInfo = new AnimalIdInfo();

        public void SetAnimalIdInfo(int idNum, String owner)
        {
            animeIdInfo.IDNum = idNum;
            animeIdInfo.Owner = owner;
        }

        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{name} has the id of {animeIdInfo.IDNum} and is owned by {animeIdInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} says {Sound}");
        }
        //private string name;
        //private string sound;
        //public static int numOfAnimals = 0;
        //public const string SHELTER = "I am animals";
        //public readonly int idNum;

        public Animal() : this("No Name", "No Sound") { }

        //public Animal() {

        //    name = "No Name";
        //    sound = "No Sound";
        //    numOfAnimals++;
        //}

        public Animal(string name) : this(name, "No Sound") { }

        public Animal(string name,string sound)
        {
            Name = name;
            Sound = sound;
            Random rnd = new Random();
            //NumOfAnimals = 1;
            //idNum = rnd.Next(1, 23434343);
        }

        //public Animal(string name = "No Name")
        //{
        //    this.name = name;
        //    this.sound = "No Sound";
        //    numOfAnimals++;
        //}

        //public Animal(string name = "No Name", string sound = "No Sound")
        //{
        //    this.name = name;
        //    this.sound = sound;
        //    numOfAnimals++;
        //}

        //public void makeSound()
        //{
        //    Console.WriteLine("{0} says {1}", name, sound);
        //}

        //public static int getNumAnimals()
        //{
        //    return numOfAnimals;
        //}

        // One way of defining the getters
        //public void SetName(string name)
        //{
        //    if(!name.Any(char.IsDigit))
        //    {
        //        this.name = name;
        //    }else
        //    {
        //        this.name = "No Name";
        //        Console.WriteLine("Name cannot contain numbers");
        //    }
        //}
        //// One way of defining the getters
        //public string GetName()
        //{
        //    return name;
        //}

        public string Name
        {
            get { return name; }
            set
            {
               
                if(value.Any(char.IsDigit))
                {
                    name = "No Name";
                    Console.WriteLine("Name cannot have numbers in name");
                }
               
                    name = value;
             
            }
        }

        public string Sound
        {
            // Another way of defining the getters and setters
            get { 
                return sound;
            }
            set
            {
                if(value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound  is too long");
                }else
                {
                    sound = value;
                }
            }
        }

        public String Owner { get; set; } = "No Owner";
        //public static int NumOfAnimals
        //{
        //    get { return numOfAnimals; }
        //    set { numOfAnimals += value; }
        //}

        //public int IdNum
        //{
        //    get { return idNum; }
        //}
    }
}
