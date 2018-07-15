using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryMethodPattern.Types;

namespace FactoryMethodPattern
{
    class GiacomoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaTypes pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaTypes.Verona:
                    return new PizzaVerona();
                case PizzaTypes.Napolitana:
                    return new PizzaNapolitana();
                case PizzaTypes.Margherita:
                    return new PizzaMargherita ();
                default:
                    return new PizzaNoPizza();
            }
        }
    }
}
