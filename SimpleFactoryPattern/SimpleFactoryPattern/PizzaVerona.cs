using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class PizzaVerona : Pizza
    {
        public PizzaVerona()
        {
            _ingredients = new string[] { "Tomato", "Cheese", "Tuna", "Olives" };
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Simply Verona!");
            base.PrintDescription();
        }
    }
}
