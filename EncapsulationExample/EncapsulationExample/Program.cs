using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            pen.Refill();

            Bike bike = new Bike();
            bike.EngineCapacity();
        }
    }
}
