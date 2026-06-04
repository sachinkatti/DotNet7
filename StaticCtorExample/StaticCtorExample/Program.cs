using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PriceCalculation;
namespace StaticCtorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Price.GetPrice();
            Console.WriteLine("Old price is :" + Price.GetPrice());
            Console.WriteLine("New price is :" + Price.SetPrice(100));

            Console.WriteLine("************* Class Library Project Example *****************");
            CalculationExtension priceCalculation = new CalculationExtension();
            Console.WriteLine(Convert.ToString( priceCalculation.CalculatePrice(100, 2)));
            Console.WriteLine(Convert.ToString(priceCalculation.CalculatePrice(306, 12)));
            Console.WriteLine(Convert.ToString(priceCalculation.CalculatePrice(555, 21)));


        }
    }
}
