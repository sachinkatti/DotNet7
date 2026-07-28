using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Foo",
                age = 34,
                AadharNumber = "1234-5678-9812"
            };

            Person person1 = new Person();
            person1.Name = "Joo";
            person1.age = 1;
            person1.AadharNumber = "1234-5678-9813";

            person.DisplayInfo();
            person.DisplayAadharInfo();

            person1.DisplayInfo();
            person1.DisplayAadharInfo();

        }
    }
}
