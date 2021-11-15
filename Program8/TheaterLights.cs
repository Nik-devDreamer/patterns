using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("TheaterLights on");
        }

        public void Off()
        {
            Console.WriteLine("TheaterLights off");
        }

        public void Dim(int value)
        {
            Console.WriteLine("TheaterLights dimming: {0}%", value);
        }
    }
}
