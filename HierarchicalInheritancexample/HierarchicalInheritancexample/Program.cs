using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritancexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.AnimalInfo();

            Cat cat = new Cat();
            cat.AnimalInfo();
            cat.Meow();
        }
    }
}
