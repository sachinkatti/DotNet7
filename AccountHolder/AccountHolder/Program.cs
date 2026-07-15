using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyPin pin = new MyPin();
            //pin.ShowPin();

            MyPin pin1 = new MyPin("abc");

            Credit credit = new Credit();
            credit.CreditAmount();
            credit.DebitAmount();
        }
    }
}
