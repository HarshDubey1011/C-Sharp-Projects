using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    internal class ZooAnimal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public bool IsCarnivore { get; set; }

        public override string ToString()
        {
            return $"Name : {Name}, Speciesv : {Species}, Age : {Age}, IsCarnivore : {IsCarnivore}";
        }
    }

}
