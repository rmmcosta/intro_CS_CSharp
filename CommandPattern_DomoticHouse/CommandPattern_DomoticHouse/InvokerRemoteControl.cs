using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    abstract class InvokerRemoteControl
    {
        ICommand[] _onCommands = new ICommand[7];
        ICommand[] _offCommands = new ICommand[7];

        public void SetOnCommand(ICommand command, int position)
        {
            _onCommands[position] = command;
        }

        public void SetOffCommand(ICommand command, int position)
        {
            _onCommands[position] = command;
        }
    }
}
