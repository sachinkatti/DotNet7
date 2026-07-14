using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MathStaticExample
{
    public static class Calculator
    {
        public static int  add(int a, int b)
        {
            return a+b;
        }

        public static int substract(int a, int b)
        {
            return a - b;
        }

        public static int multi(int a, int b)
        {
            return a * b;
        }

        public static double divide(int a, int b)
        {
            return (double) a / b;
        }
    }
}
