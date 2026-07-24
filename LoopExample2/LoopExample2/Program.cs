using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LoopExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 5; i <= j; i++, j--)
            {
                Console.WriteLine("i = " + i + " j = " + j);

            }

            Console.WriteLine("Example 3 :");
            for(int i = 1; i<=3; Console.WriteLine(i),i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine("Reverse String Example");
            string name = "SachinS";
            char c = 'S';

            int count = 0;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);

                if (name[i] == c)
                {
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Count = " + count);
        }

    }
    }
 
