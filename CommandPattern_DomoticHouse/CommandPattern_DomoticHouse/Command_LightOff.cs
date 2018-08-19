using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    class Command_LightOff : ICommand
    {
        Receiver_Light light;

        public Command_LightOff(Receiver_Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void UnExecute()
        {
            light.On();
        }
    }
}
