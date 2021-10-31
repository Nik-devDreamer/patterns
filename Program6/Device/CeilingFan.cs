using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6.Device
{
    public class CeilingFan
    {
        public int high = 3;
        public int medium = 2;
        public int low = 1;
        public int off = 0;
        public int Speed;

        public void High()
        {
            Console.WriteLine("Вентиляторы работают в высоком режиме");
            Speed = high;
        }

        public void Medium()
        {
            Console.WriteLine("Вентиляторы работают в среднем режиме");
            Speed = medium;
        }

        public void Low()
        {
            Console.WriteLine("Вентиляторы работают в слабом режиме");
            Speed = low;
        }

        public void Off()
        {
            Console.WriteLine("Вентилятор выключен");
            Speed = off;
        }

        public int GetSpeed()
        {
            return Speed;
        }
    }
}
