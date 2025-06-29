using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    internal class ZooCage<T> : IZooCage<T> where T : Animal
    {
        private List<T> lst = new List<T>();
        public void addAnimals(T animal)
        {
           lst.Add(animal); 
        }

        public void displayAllAnimals()
        {
            foreach (var animal in lst) {
                Console.WriteLine($"{animal.Name}");
            }
        }

        public T getAnimal(int index)
        {
            if(index>=0 && index<lst.Count) return lst[index];
            throw new IndexOutOfRangeException("Invalid Index u bitch#");
            
        }
    }
}
