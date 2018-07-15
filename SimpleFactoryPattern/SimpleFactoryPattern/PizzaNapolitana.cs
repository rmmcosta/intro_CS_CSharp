using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class PizzaNapolitana : Pizza
    {
        public PizzaNapolitana()
        {
            _ingredients = new string[] { "Tomato", "Cheese", "Smoked Ham", "Onions" };
        }

        public override void PrintDescription()
        {
            Console.WriteLine("This is the Amazing Napolitana!");
            base.PrintDescription();
        }
    }
}
