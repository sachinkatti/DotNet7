using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model(101);
            Model model1 = new Model("Sac", 101);
        }
    }
}
