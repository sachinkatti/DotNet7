using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    public class Price
    {
        public void CalculatePrice(int quantity, decimal unitPrice)
        {
            try
            {
                if (quantity <0)
                {
                    quantity = 0;
                }
            }
            catch
            { Console.WriteLine("Handled"); }
        }
    }
}
