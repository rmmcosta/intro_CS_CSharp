using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class SimplePizza : Pizza
    {
        PizzaFactory _pizzaFactory;

        public SimplePizza(String name, PizzaFactory pizzaFactory)
        {
            _name = name;
            _pizzaFactory = pizzaFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
            _dough = _pizzaFactory.CreateDough();
            _sauce = _pizzaFactory.CreateSauce();
        }
    }
}
