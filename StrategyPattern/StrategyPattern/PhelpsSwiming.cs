using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class PhelpsSwiming : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Swim Phelps, Swim and get out of my way!");
        }
    }
}
