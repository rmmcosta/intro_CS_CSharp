using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryMethodPattern.Types;

namespace FactoryMethodPattern
{
    abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaTypes pizzaType)
        {
            Pizza pizza;

            pizza = CreatePizza(pizzaType);
            //this store has the given pizza?
            if(!pizza.GetType().Equals(typeof(PizzaNoPizza)))
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }
            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaTypes pizzaType);
    }
}
