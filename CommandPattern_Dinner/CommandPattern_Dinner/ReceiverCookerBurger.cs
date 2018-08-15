using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Dinner
{
    abstract class ReceiverCookerBurger
    {
        public virtual void MakeBurger()
        {
            Console.WriteLine("Burger Done!");
        }
    }
}
