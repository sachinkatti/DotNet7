using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExampleType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetEmployeeName();
            Console.WriteLine(employee.GetEmployeePan());
            Console.WriteLine(employee.GetEmployeeSalary(123));

            Calculator calculator = new Calculator();
            Console.WriteLine("Addition: " + calculator.Addition(5,4));
            Console.WriteLine("Substraction: " + calculator.Substraction(5,4));
            Console.WriteLine("Multiflication: " + calculator.Multiflication(55.1,33.1));
            Console.WriteLine("Divide: " + calculator.Divide(5.4m,6.4m));
        }
    }
}
