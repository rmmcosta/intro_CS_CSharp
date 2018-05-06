using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IComunication myHttp = new Http("www.pacorainha.pt",80);
            IComunication myUsb = new Usb();
            Usb otherUsb = new Usb();
            myHttp.Protocol();
            myUsb.Protocol();
            otherUsb.Protocol();
            Console.WriteLine(myHttp.GetType() == myUsb.GetType());
            Console.WriteLine(myHttp.GetType() == otherUsb.GetType());

        }
    }
}
