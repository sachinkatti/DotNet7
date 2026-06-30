using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDelegate
{
    internal class Program
    {
        public delegate void CalcDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalcDelegate calcDelegate = Addition;
            calcDelegate(10, 20);
            calcDelegate += Substraction;
            calcDelegate += Multiplication;
            calcDelegate += Division;
            calcDelegate(10, 2);
        }
        public static void Addition(int a, int b)
        {
            Console.WriteLine("Addition is: " + (a + b));
        }
        public static void Substraction(int a, int b)
        {
            Console.WriteLine("Substraction is: "+ (a - b));
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication is: " + (a * b));
        }
        public static void Division(int a, int b)
        {
            Console.WriteLine("Division is: " + (a / b));
        }
    }
}
