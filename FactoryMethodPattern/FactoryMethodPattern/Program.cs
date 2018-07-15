using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryMethodPattern.Types;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            PizzaStore pizzaStore = new GiacomoPizzaStore();
            Console.WriteLine("I want a pizza.");
            pizza = pizzaStore.OrderPizza(PizzaTypes.Margherita);
            pizza.PrintDescription();
            Console.WriteLine("For me one Napolitana please.");
            pizza = pizzaStore.OrderPizza(PizzaTypes.Napolitana);
            pizza.PrintDescription();
            pizza = pizzaStore.OrderPizza(PizzaTypes.Portuguesa);
            pizza.PrintDescription();

            Console.WriteLine("What about in a Portuguese Pizzaria. Ricardos for example.");
            pizzaStore = new RicardosPizzeria();
            pizza = pizzaStore.OrderPizza(PizzaTypes.Portuguesa);
            pizza.PrintDescription();
            Console.WriteLine("Sai uma Margarita!");
            pizza = pizzaStore.OrderPizza(PizzaTypes.Margherita);
            pizza.PrintDescription();
        }
    }
}
