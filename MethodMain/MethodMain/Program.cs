using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodOverloadExample1;

namespace MethodMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            Console.WriteLine($"Sum is : {addition.Add(10, 20)}");
            Console.WriteLine($"Sum is : {addition.Add(10, 20, 30)}");
        }
    }
}
