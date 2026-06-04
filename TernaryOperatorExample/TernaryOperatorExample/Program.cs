using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 75;

            string result = (i % 2 == 0) ? "Even" : "odd";
            Console.WriteLine(result);
        }
    }
}
