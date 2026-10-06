using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeywordExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int basePrice = 10; //and reinitialization will not happen.
            Console.WriteLine("Welcome to the store");
            Console.WriteLine($"The base price of the item is : {basePrice} dollers.");


            Price price = new Price(20);
            price.DisplayPrice();

            //basePrice = 20; //this line will cause a complie time error because baseprice is constant.
        }
    }
}
