using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyCtorExample
{
    public class Address
    {
        public string _addressLine1;
        public string _addressLine2;

        public Address(string addressLine1, string addressLine2)
        {
            this._addressLine1 = addressLine1;
            this._addressLine2 = addressLine2;
        }

        public Address(Address address)
        {
            _addressLine1 = address._addressLine1;
            _addressLine2 = address._addressLine2;
        }

        public void PrintAddress()
        {
            Console.WriteLine("My Address is "+ _addressLine1 +" "+ _addressLine2);
        }

        public void ShowAddress()
        {
            PrintAddress();
        }
    }
}
