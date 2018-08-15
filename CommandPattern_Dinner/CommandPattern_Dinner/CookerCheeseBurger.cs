using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Dinner
{
    class CookerCheeseBurger : ReceiverCookerBurger
    {
        public override void MakeBurger()
        {
            Console.WriteLine("Cheese Burger Done!");
        }
    }
}
