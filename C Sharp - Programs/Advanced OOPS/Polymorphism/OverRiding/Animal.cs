using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverRiding
{
    public class Animal
    {
        public virtual string Sound()
        {
            return "Animal Sound";
        }
    }
    public class Dog : Animal
    {
        public override string Sound()
        {
            return "Dog Sound";
        }
    }
    public class Pomerian : Dog
    {
        public override string Sound()
        {
            return "Pomerian Sound";
        }
    }
}