using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class NoFlying : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I prefer to stay on the ground!");
        }
    }
}
