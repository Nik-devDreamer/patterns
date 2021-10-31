using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6.Device
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включён");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }

        public void SetInputChannel(int value)
        {
            Console.WriteLine("Канал {0} включён", value);
        }

        public void SetVolume(int value)
        {
            Console.WriteLine("Громкость {0}", value);
        }
    }
}
