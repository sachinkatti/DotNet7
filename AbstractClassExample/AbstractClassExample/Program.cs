using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlackWhitePrinter bw = new BlackWhitePrinter();

            bw.GetPaper();
            bw.Print();
            bw.BlackWhitePrint();
        }
    }
}
