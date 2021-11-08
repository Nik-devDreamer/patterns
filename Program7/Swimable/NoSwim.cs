using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program7.Swimable
{
    class NoSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Утка не умеет плавать");
        }
    }
}
