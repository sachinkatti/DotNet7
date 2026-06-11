using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 20;
                int b = 30;
                int result = a / b;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("final f1");
            } }
            finally 
            {
                Console.WriteLine();
            }
        }
    }
}
