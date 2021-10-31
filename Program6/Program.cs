using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program6.Device;
using Program6.Commands;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();

            LightOnCommand onLight = new LightOnCommand(light);
            LightOffCommand offLight = new LightOffCommand(light);

            remoteControl.SetCommand(0, onLight, offLight);
            remoteControl.PushOnButton(0);
            remoteControl.PushOffButton(0);
            Console.ReadKey();
        }
    }
}
