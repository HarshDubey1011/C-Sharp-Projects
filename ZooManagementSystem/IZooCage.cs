using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    internal interface IZooCage<T> where T : Animal
    {
        void addAnimals(T animal);
        T getAnimal(int index);

        void displayAllAnimals();
    }
}
