using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addtion :"+ Calculator.add(10,20));
            Console.WriteLine("Substract :" + Calculator.substract(60, 20));
            Console.WriteLine("Multi :" + Calculator.multi(13, 21));
            Console.WriteLine("Divide :" + Calculator.divide(100, 20));
        }
    }
}
