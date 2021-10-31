using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6.Device
{
    public class Hottub
    {
        public void Circulate()
        {
            Console.WriteLine("Circulating");
        }

        public void JetsOn()
        {
            Console.WriteLine("Jets on");
        }

        public void JetsOff()
        {
            Console.WriteLine("Jets off");
        }

        public void SetTemperature(int value)
        {
            Console.WriteLine("Temperature: {0}", value);
        }
    }
}
