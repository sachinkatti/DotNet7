using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;

            //Console.WriteLine("Give above Max Number is");

            if ((a > b && a > c))
            {
                Console.WriteLine("Greatest number is :" + a);
            }
            else if ((b > a && b > c))
            {
                Console.WriteLine("Greatest number is :" + b);
            }
            else
            {
                Console.WriteLine("Greatest number is :" + c);
            }

            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year ✅");
            }
            else
            {
                Console.WriteLine($"{year} is NOT a Leap Year ❌");
            }

        

        }
        }
    }

