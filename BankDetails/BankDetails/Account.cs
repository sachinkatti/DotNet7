using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails
{
    public class Account
    {
        public decimal Balance(decimal a)
        {
            return a;
        }
        public void WithDrawAmout(decimal b)
        {
            Console.WriteLine("WithDraw Amount is : " + b);
        }

    }
}
