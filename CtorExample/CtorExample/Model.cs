using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorExample
{
    public class Model
    {
        public Model(int id)
        {
            Console.WriteLine("A");
        }

        public Model(string name, int id)
        {
            Console.WriteLine("B");
        }
    }
}
