using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritance
{
    public class Aadhar
    {
        public string AadharNumber {  get; set; }

        pubic void DisplayAadharInfo()
        {
            Console.WriteLine($"Aadhar Number : {AadharNumber}");
        }
    }
}
