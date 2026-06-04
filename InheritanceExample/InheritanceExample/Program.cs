using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Name = "Sachin";
            manager.Salary = 60000;
            manager.Bonus = 10000;

            manager.ShowManagerDetails();
        }
    }
}
