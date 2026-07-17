using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenExample
{
    internal class Program
    {
        static void Main(string[] args)
         {
            int number;

            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

           if(number % 2 == 0)
            {
                Console.WriteLine("Its a even");
            }
            else
            {
                Console.WriteLine("its a odd");

            }
        }
    }
}
