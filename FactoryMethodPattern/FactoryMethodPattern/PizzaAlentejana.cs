using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class PizzaAlentejana:Pizza
    {
        public PizzaAlentejana()
        {
            _ingredients = new string[] { "Tomate", "Queijo", "Migas" };
        }
    }
}
