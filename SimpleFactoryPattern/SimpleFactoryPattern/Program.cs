using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleFactoryPattern.Types;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            SimplePizzaFactory santanaFactory = new SimplePizzaFactory();
            PizzaStore santanaPizzaria = new PizzaStore(santanaFactory);
            Console.WriteLine("I want a pizza.");
            pizza = santanaPizzaria.OrderPizza();
            pizza.PrintDescription();
            Console.WriteLine("For me one Napolitana please.");
            pizza = santanaPizzaria.OrderPizza(PizzaTypes.Napolitana);
            pizza.PrintDescription();
        }
    }
}
