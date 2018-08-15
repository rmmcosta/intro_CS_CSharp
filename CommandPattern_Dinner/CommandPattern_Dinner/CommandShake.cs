using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Dinner
{
    class CommandShake : ICommand
    {
        ReceiverCookerShake _receiverCookerShake;

        public CommandShake(ReceiverCookerShake receiverCookerShake)
        {
            _receiverCookerShake = receiverCookerShake;
        }

        public void Execute()
        {
            _receiverCookerShake.MilkShake();
        }
    }
}
