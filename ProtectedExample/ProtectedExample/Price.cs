using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedExample
{
    public sealed class BasePrice
    {
        public BasePrice()
        {
            Console.WriteLine("Base Price Constructor called");
        }
        public int Price;

        public void DisplayPrice()
        {
            Console.WriteLine($"the price is : {Price}");
        }

        //protected void Show()
        //{
        //    DisplayPrice();
        //    Console.WriteLine($"the price is : {price}");
        //}
    }

    //public class Price : BasePrice
    //{
    //    public Price(int initialPrice)
    //    {
    //        price1 = initialPrice;
    //    }
    //    public void ShowPrice()
    //    {
    //        DisplayPrice(); // Calling the protected method from the base class
    //    }
    //}
}
