using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritancexample
{
    public class Animal
    {
        public void AnimalInfo()
        {
            Console.WriteLine("Animal Information");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }

    public class Cat : Animal 
    {
        public void Meow()
        {
            Console.WriteLine("Meow Meow........");
        }
    }

    public class Elephant
    {
        public void Bark()
        {
            Console.WriteLine("The elephant Barking");
        }
    }
}
