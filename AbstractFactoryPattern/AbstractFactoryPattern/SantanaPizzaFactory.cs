using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class SantanaPizzaFactory : PizzaFactory
    {
        public Cheese CreateCheese()
        {
            return new Parmegianno();
        }

        public Dough CreateDough()
        {
            return new ThinCrust();
        }

        public Sauce CreateSauce()
        {
            return new Marinara();
        }
    }
}
