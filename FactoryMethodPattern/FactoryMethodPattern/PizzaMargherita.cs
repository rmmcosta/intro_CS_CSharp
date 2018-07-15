using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class PizzaMargherita :Pizza
    {
        public PizzaMargherita ()
        {
            _ingredients = new string[] { "Tomato", "Cheese", "Ham" };
        }
    }
}
