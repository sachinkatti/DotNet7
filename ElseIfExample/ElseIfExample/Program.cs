using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;

            Console.WriteLine("Enter Your Marks");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 90)
            {
                Console.WriteLine("Distinction");
            }
            else if (marks > 80)
            {
                Console.WriteLine("First Class");
            }
            else if (marks > 70)
            {
                Console.WriteLine("Second Class");
            }
            else if (marks > 35)  
            {
                Console.WriteLine("All Exam Pass");
            }
            else
            {
                Console.WriteLine("Fail"); 
            }
        }
    }
}