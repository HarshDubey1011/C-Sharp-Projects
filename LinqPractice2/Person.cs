﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice2
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, City: {City}";
        }
    }
}
