using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceKeywordExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            int value2;
            //Console.WriteLine("Value before method call :" + value);


            Price price = new Price();
            //int result = price.GetPrice(ref value);
            //Console.WriteLine("value after method call : "+value);
            //Console.WriteLine("Result : "+result);

            int result1 = price.GetPrice(out value, out value2);
            Console.WriteLine("value after method call : "+value);
            Console.WriteLine("value after method call : "+value2);
            Console.WriteLine("Result : "+result1);
        }
    }
}
