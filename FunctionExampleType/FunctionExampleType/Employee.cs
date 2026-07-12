using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExampleType
{
    public class Employee
    {
        public void GetEmployeeName()
        {
            Console.WriteLine("Sachin");
        }

        public string GetEmployeePan()
        {
            return("Irspk96d");
        }

        public decimal GetEmployeeSalary(int empId)
        {
            return 2343233424.4m;
        }
    }
}
