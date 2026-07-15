using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHolder
{
    public class MyPin
    {
        private MyPin() 
        {

        }

        public MyPin(string pin)
        {
            Console.WriteLine(" My pin is :" +pin);
        }

        public void ShowPin()
        {
            Console.WriteLine(" My pin is 1234 ");
        }
    }
}
