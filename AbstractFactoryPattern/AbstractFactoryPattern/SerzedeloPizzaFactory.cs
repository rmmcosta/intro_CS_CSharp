using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class SerzedeloPizzaFactory : PizzaFactory
    {
        public Cheese CreateCheese()
        {
            return new Mozarella();
        }

        public Dough CreateDough()
        {
            return new ThickCrust();
        }

        public Sauce CreateSauce()
        {
            return new Tomato();
        }
    }
}
