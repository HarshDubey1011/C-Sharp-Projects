using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers
{
    internal class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttkMax { get; set; }
        public  double BlockMax { get; set; }

        Random rnd = new Random();

        public Warrior(string Name = "Warrior", double Health = 0 , double AttkMax = 0 ,double BlockMax = 0)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttkMax = AttkMax;
            this.BlockMax = BlockMax;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        public virtual double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
