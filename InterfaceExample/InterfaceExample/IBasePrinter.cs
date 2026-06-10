using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IBasePrinter
    {
        void Print();
        void ColorPrint();
    }

    public class Printer : IBasePrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void ColorPrint()
        {
            Console.WriteLine("Printing color document...");
        }
    }
    }
