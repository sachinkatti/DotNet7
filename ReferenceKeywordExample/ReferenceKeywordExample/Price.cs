using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceKeywordExample
{
    public class Price
    {
        //public int GetPrice(ref int value)
        //{
        //    value = 200;
        //    return 100;
        //}

        public int GetPrice(out int value, out int value2)
        {
            value = 200;
            value2 = 300;
            return 100;
        }
    }
}
