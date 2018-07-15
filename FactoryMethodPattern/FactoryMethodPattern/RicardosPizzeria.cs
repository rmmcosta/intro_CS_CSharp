using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryMethodPattern.Types;

namespace FactoryMethodPattern
{
    class RicardosPizzeria : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaTypes pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaTypes.Alentejana:
                    return new PizzaAlentejana();
                case PizzaTypes.Portuguesa:
                    return new PizzaPortuguesa();
                case PizzaTypes.Margherita:
                    return new PizzaMargaritaPortuguesa();
                default:
                    return new PizzaNoPizza();
            }
        }
    }
}
