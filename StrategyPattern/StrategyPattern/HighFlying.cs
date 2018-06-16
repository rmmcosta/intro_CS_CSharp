using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class HighFlying : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I Like to fly to the moon and back!");
        }
    }
}
