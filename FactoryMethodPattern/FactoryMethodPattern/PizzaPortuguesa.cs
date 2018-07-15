using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class PizzaPortuguesa:Pizza
    {
        public PizzaPortuguesa()
        {
            _ingredients = new string[] { "Tomate", "Queijo", "Presunto" };
        }
    }
}
