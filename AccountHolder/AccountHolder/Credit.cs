using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHolder
{
    public partial class Credit
    {
        public Credit()
        {
            Console.WriteLine("Credit class constructor");
        }

        public void CreditAmount()
        {
            Console.WriteLine("Credit Amount is 10000");
        }
    }

        public partial class Credit
        {
            public Credit(string amount)
            {
                Console.WriteLine("redit class constructo");
            }

        public void DebitAmount()
        {
            Console.WriteLine("Debit Amount is 500");
        }
    }
}
