using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    class Receiver_Light
    {
        public void On()
        {
            Console.WriteLine($"Light {this.GetHashCode()} ON!");
        }

        public void Off()
        {
            Console.WriteLine($"Light {this.GetHashCode()} OFF!");
        }
    }
}
