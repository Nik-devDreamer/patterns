using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    public class CdPlayer
    {
        public void On()
        {
            Console.WriteLine("CdPlayer on");
        }

        public void Off()
        {
            Console.WriteLine("CdPlayer off");
        }

        public void Eject()
        {
            Console.WriteLine("Cd eject");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Play(string title)
        {
            Console.WriteLine("Cd playing: {0}", title);
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
