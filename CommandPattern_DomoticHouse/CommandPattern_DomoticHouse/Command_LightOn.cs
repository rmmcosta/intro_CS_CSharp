using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    class Command_LightOn : ICommand
    {
        Receiver_Light light;

        public Command_LightOn(Receiver_Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void UnExecute()
        {
            light.Off();
        }
    }
}
