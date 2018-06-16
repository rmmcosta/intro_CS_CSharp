using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck cityDuck = new Duck(new NoFlying(), new ShortSwiming(), new ShortWalking());
            Duck countryDuck = new Duck(new HighFlying(), new NoSwiming(), new RunWalking());
            Duck rubberDuck = new Duck(new NoFlying(), new PhelpsSwiming(), new NoWalking());
            Console.WriteLine("City Duck say something!");
            cityDuck.Fly();
            cityDuck.Walk();
            cityDuck.Swim();
            Console.WriteLine("Country Duck SPEAK!");
            countryDuck.Fly();
            countryDuck.Walk();
            countryDuck.Swim();
            Console.WriteLine("Rubber Duck? Ruuuuubbbber Duuuuck?");
            rubberDuck.Fly();
            rubberDuck.Walk();
            rubberDuck.Swim();
        }
    }
}
