using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    class Receiver_TV
    {
        public void On()
        {
            Console.WriteLine($"TV {this.GetHashCode()} ON!");
        }

        public void Off()
        {
            Console.WriteLine($"TV {this.GetHashCode()} OFF!");
        }
    }
}
