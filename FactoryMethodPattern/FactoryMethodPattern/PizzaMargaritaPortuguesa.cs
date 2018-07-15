using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class PizzaMargaritaPortuguesa : Pizza
    {
        public PizzaMargaritaPortuguesa()
        {
            _ingredients = new string[] { "Tomate", "Queijo", "Fiambre" };
        }

        public override void Cut()
        {
            Console.WriteLine("Zé não cortes a Piza...");
        }
    }
}
