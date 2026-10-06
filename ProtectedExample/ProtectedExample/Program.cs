using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Price price = new Price(100);
            //price.ShowPrice();

            BasePrice bp = new BasePrice();

            bp.DisplayPrice();

            Console.WriteLine("Enter the day of the week");
            string dayInput = Console.ReadLine();

            if (dayInput == Day.Monday.ToString())
            {

                Console.WriteLine("It's monday!");
            }

        }
    }
}
