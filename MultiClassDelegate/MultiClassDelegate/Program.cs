using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClassDelegate
{
    internal class Program
    {
        public delegate void MyDelegate(string message);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Print;
            myDelegate += Display;
            myDelegate("Hello simple Multi class delegate");
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static void Display(string message)
        {
            Console.WriteLine(message);
        }
        public static void Show(string message, string content)
        {
            Console.WriteLine(message + content);
        }
    }
}