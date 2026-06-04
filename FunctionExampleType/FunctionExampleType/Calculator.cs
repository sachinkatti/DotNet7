using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExampleType
{
    public class Calculator
    {
        public int Addition(int c, int d)
        {
            return c + d;
        }

        public int Substraction(int a, int b)
        {
            return a - b;
        }

        public double Multiflication(double a, double b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return (decimal) (a / b);
        }
    }
}
