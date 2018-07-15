using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleFactoryPattern.Types;

namespace SimpleFactoryPattern
{
    class SimplePizzaFactory
    {
        public Pizza CreatePizza(PizzaTypes pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaTypes.Verona:
                    return new PizzaVerona();
                case PizzaTypes.Napolitana:
                    return new PizzaNapolitana();
                case PizzaTypes.Margherita:
                default: 
                    return new PizzaMargherita();
            }
        }
    }
}
