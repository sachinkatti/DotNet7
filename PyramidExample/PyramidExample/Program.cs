using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int rows = 5;
                int i = 1;

                do
                {
                    int j = 1;

                    do
                    {
                        if (j <= rows - i)
                        {
                            Console.Write(" ");
                        }

                        j++;
                    }
                    while (j <= rows);

                    int k = 1;

                    do
                    {
                        Console.Write("*");
                        k++;
                    }
                    while (k <= (2 * i - 1));

                    Console.WriteLine();

                    i++;
                }
                while (i <= rows);

            Console.WriteLine("*******For Loop Example**********");
        }
        }
    }
 
