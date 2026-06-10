using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstnumber = 10;
                int secondnumber = Convert.ToInt32(Console.ReadLine());
                int result = firstnumber / secondnumber;
                Console.WriteLine("Hello");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Occurred : {ex.Message}");
                Console.WriteLine($"An Error Occurred : {ex.StackTrace}");
            }

            finally
            {
                Console.WriteLine("This block will always executed");
            }

        }
    }
}
