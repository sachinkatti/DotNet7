using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOveridingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.Print();

            Printer cp = new ColorPrinter();
            cp.Print();

            Printer lp = new LeaserPrinter();
            lp.Print();
        }
    }
}
