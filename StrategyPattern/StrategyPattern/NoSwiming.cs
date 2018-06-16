using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class NoSwiming : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I am afraid of water!");
        }
    }
}
