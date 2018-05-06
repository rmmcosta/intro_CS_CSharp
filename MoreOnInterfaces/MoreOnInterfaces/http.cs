using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnInterfaces
{
    class Http:IComunication
    {
        private string _config;
        private int _port;
        public Http(string config, int port)
        {
            _config = config;
            _port = port;
        }
        public void Protocol()
        {
            Console.WriteLine("The configuration {0} and the port {1}",_config,_port);
        }
    }
}
