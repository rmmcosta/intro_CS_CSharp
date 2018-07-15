using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class PizzaNoPizza:Pizza
    {
        public override void PrintDescription()
        {
            Console.WriteLine("We don't have that pizza!");
        }
    }
}
