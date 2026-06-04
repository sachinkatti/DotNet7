using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBankingExample
{
    public class Account
    {
        public double Balance { get; set; }

        public void Deposite(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited : {amount}");
        }
    }
}
