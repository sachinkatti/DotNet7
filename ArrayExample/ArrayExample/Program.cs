using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5 };
            int minNumber = number[0];
            int maxNumber = number[0];


            if (number.Length >= 0)
            {
                foreach(int i in number)
                {
                    if (minNumber > i)
                    {
                        minNumber = i;
                    }
                    if (maxNumber < i)
                    {
                        maxNumber = i;
                    }
                }
            }
            Console.WriteLine("Max number " + maxNumber);
            Console.WriteLine("Min number " + minNumber);
        }
    }
}
