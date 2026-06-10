using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeywordExample
{
    public class Price
    {
        public readonly int basePrice;

        public Price (int price)
        {
            basePrice = price;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"The base price of the item is : {basePrice} dollers.");
        }
    }
}
