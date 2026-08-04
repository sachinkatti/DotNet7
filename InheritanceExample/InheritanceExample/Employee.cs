using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public void Display()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}
