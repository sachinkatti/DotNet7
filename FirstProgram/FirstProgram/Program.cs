using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result1 = calc.Addition(5,3);
            int result2 = calc.Substraction(5,3);
            Console.WriteLine("Addition :" + result1);
            Console.WriteLine("Substraction :" + result2);
        }
    }
}
