using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBankingExample
{
    public class SavingAccount : Account
    {
        public void AddInterest()
        {
            Balance += Balance * 0.05;
            Console.WriteLine($"Balance after interest: {Balance}");
        }
    }
}
