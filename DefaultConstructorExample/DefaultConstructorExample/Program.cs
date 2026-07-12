using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("TCS");
            company.CompanyDirector();
            
            Company company1 = new Company();
            Console.ReadLine();
        }
    }
}
