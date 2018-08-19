using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    class Client
    {
        static void Main(string[] args)
        {
            Invoker_RemoteControl remoteControl = new Invoker_RemoteControl();
            ConfigureRemoteControlLight(remoteControl,0);

            remoteControl.ButtonClick(0, Invoker_RemoteControl.ButtonType.ON);
            remoteControl.ButtonClick(0, Invoker_RemoteControl.ButtonType.OFF);

            remoteControl.ButtonClick(1, Invoker_RemoteControl.ButtonType.OFF);

            ConfigureRemoteControlTV(remoteControl,1);
            remoteControl.ButtonClick(1, Invoker_RemoteControl.ButtonType.OFF);
            remoteControl.ButtonClick(1, Invoker_RemoteControl.ButtonType.ON);

            ConfigureRemoteControlLight(remoteControl, 2);
            remoteControl.ButtonClick(2, Invoker_RemoteControl.ButtonType.OFF);
            remoteControl.ButtonClick(2, Invoker_RemoteControl.ButtonType.ON);

            Console.WriteLine("Let's undo every thing!");

            remoteControl.Undo();


        }

        static void ConfigureRemoteControlLight(Invoker_RemoteControl remoteControl, int position)
        {
            Receiver_Light livingRoomLight = new Receiver_Light();
            Command_LightOn livingRoomLightOn = new Command_LightOn(livingRoomLight);
            remoteControl.SetOnCommand(livingRoomLightOn, position);

            Command_LightOff livingRoomLightOff = new Command_LightOff(livingRoomLight);
            remoteControl.SetOffCommand(livingRoomLightOff, position);
        }

        static void ConfigureRemoteControlTV(Invoker_RemoteControl remoteControl, int position)
        {
            Receiver_TV livingRoomTV = new Receiver_TV();
            Command_TVOn livingRoomTVOn = new Command_TVOn(livingRoomTV);
            remoteControl.SetOnCommand(livingRoomTVOn, position);

            Command_TVOff livingRoomTVOff = new Command_TVOff(livingRoomTV);
            remoteControl.SetOffCommand(livingRoomTVOff, position);
        }
    }
}
