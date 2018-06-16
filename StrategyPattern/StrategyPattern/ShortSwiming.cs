using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ShortSwiming : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I only swim in pools!");
        }
    }
}
