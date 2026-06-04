using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person Constructor Called");
        }
        public void PersonInfo()
        {
            Console.WriteLine("This is Person Info");
        }
    }

    public class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("Employee Constructor Called");
        }
        public void EmployeeInfo()
        {
            Console.WriteLine("This is Employee Info");
        }
    }

    public class  Manager : Employee 
    {
        public Manager()
        {
            Console.WriteLine("Manager Constructor Called");
        }
        public void ManagerInfo()
        {
            Console.WriteLine("This is Manager Info");
        }
    }
}
