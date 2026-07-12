using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value = 12.4f;
            Console.WriteLine(value);

            double value2 = 12.34555555555555555; 
            Console.WriteLine(value2);

            decimal value3 = 1267676.345555555555555556666666666666666666666453636346365m;
            Console.WriteLine(value3);

            bool submitflag;
            submitflag = true;
            Console.WriteLine(submitflag);

            char name;
            name = 's';
            Console.WriteLine(name);

            Price price = new Price();
            Console.WriteLine(price.GetPrice());

            DateTime current = DateTime.Now;
            Console.WriteLine(current);

        }
    }
}
