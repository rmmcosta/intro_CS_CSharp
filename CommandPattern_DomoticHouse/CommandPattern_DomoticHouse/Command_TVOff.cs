using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    class Command_TVOff : ICommand
    {
        Receiver_TV tv;

        public Command_TVOff(Receiver_TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.Off();
        }
    }
}
