using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Margherita : Pizza
    {
        PizzaFactory _pizzaFactory;

        public Margherita(String name, PizzaFactory pizzaFactory)
        {
            _name = name;
            _pizzaFactory = pizzaFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
            _dough = _pizzaFactory.CreateDough();
            _cheese = _pizzaFactory.CreateCheese();
            _sauce = _pizzaFactory.CreateSauce();
        }
    }
}
