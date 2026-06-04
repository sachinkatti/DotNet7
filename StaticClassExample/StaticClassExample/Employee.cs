using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    public static class Employee
    {
        public static string GetName()
        {
            return "Sachin";
        }

        public static decimal GetSalary()
        {
            return 3456.6m;
        }
    }
}
