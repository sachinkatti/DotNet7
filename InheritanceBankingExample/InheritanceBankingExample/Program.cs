using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBankingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount account = new SavingAccount();
            account.Deposite(50000);
            account.AddInterest();


        }
    }
}
