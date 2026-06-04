using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while(i>1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 5);

            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("*");   
                }
            }
            Console.WriteLine(" ");
        }
    }
}
