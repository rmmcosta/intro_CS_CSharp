using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    class Invoker_RemoteControl
    {
        ICommand[] onCommand = new ICommand[7];
        ICommand[] offCommand = new ICommand[7];

        public enum ButtonType { ON, OFF };

        public void SetOnCommand(ICommand command, int position)
        {
            onCommand[position] = command;
        }

        public void SetOffCommand(ICommand command, int position)
        {
            offCommand[position] = command;
        }

        public void ButtonClick(int position, ButtonType buttonType)
        {
            switch (buttonType)
            {
                case ButtonType.ON:
                    if (onCommand[position] != null)
                        onCommand[position].Execute();
                    else
                        Console.WriteLine("Button not configured yet!");
                    break;
                case ButtonType.OFF:
                    if (offCommand[position] != null)
                        offCommand[position].Execute();
                    else
                        Console.WriteLine("Button not configured yet!");
                    break;
                default:
                    break;
            }
        }
    }
}
