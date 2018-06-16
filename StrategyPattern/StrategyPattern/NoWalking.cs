using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class NoWalking : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("I prefer to stay in the water!");
        }
    }
}
