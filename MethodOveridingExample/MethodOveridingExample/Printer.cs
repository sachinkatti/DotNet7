using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOveridingExample
{
    public class Printer
    {
        public virtual void Print()
        {
            Console.WriteLine("This is the base printer");
        }

        //public void ColorPrinter(string b, string l)
        //{
        //    Console.WriteLine($"Color of {b}and{l} is : {b},{l}");
        //}
    }

    public class ColorPrinter : Printer
    {
        public override void Print()
        {
            Console.WriteLine("Color Is Black");
        }
    }

    public class LeaserPrinter : Printer
    {
        public override void Print()
        {
            Console.WriteLine("This is a Lasser Printer");
        }
    }
}