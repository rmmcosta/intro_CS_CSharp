using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnInterfaces
{
    class Usb:IComunication
    {
        public void Protocol()
        {
            Console.WriteLine("This is just Usb. No need for config the port nor the configuration itself.");
        }
    }
}
