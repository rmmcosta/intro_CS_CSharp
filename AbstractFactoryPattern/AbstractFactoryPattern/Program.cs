using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Margherita("Santana Margherita", new SantanaPizzaFactory());
            pizza1.Prepare();
            pizza1.Bake();
            pizza1.Cut();
            pizza1.Box();
            pizza1.PrintDescription();
            Pizza pizza2 = new Margherita("Serzedelo Margherita", new SerzedeloPizzaFactory());
            pizza2.Prepare();
            pizza2.Bake();
            pizza2.Cut();
            pizza2.Box();
            pizza2.PrintDescription();

            Pizza pizza3 = new SimplePizza("Santana Simples", new SantanaPizzaFactory());
            pizza3.Prepare();
            pizza3.Bake();
            pizza3.Cut();
            pizza3.Box();
            pizza3.PrintDescription();
            Pizza pizza4 = new SimplePizza("Serzedelo Simples", new SerzedeloPizzaFactory());
            pizza4.Prepare();
            pizza4.Bake();
            pizza4.Cut();
            pizza4.Box();
            pizza4.PrintDescription();

        }
    }
}
