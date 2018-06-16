using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RunWalking : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("I like to walk and run at the same time!");
        }
    }
}
