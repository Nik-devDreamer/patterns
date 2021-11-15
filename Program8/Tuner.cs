using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    public class Tuner
    {
        public void On()
        {
            Console.WriteLine("Tuner on");
        }

        public void Off()
        {
            Console.WriteLine("Tuner off");
        }

        public void SetAm()
        {
            Console.WriteLine("Setting AM");
        }

        public void SetFm()
        {
            Console.WriteLine("Setting FM");
        }

        public void SetFrequency(int frequency)
        {
            Console.WriteLine("Setting frequency: {0}", frequency);
        }
    }
}
