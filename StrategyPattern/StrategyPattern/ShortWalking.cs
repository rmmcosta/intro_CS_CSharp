using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ShortWalking : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Not my fault, I have short legs.");
        }
    }
}
