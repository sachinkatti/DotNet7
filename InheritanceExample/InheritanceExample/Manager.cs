using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Manager : Employee
    {
        public double Bonus {  get; set; }
        
        public void ShowManagerDetails()
        {
            Display();
            Console.WriteLine($"Bonus : {Bonus}");
        }
    }
}
