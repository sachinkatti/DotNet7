using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            try 
            {
                
            decimal balance = account.Balance(50000);

            Console.Write("Enter withdraw amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > balance)
            {
                throw new Exception("Insufficient Balance");
            }
        }
            catch (Exception ex)
            {
                Console.WriteLine("Handled: " + ex.Message);
            }
        }
    }
}
