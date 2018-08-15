using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    class Command_TVOn : ICommand
    {
        Receiver_TV tv;

        public Command_TVOn(Receiver_TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.On();
        }
    }
}
