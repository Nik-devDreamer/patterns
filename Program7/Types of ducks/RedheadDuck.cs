using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program7.Swimable;
using Program7.Fly;
using Program7.Quack;

namespace Program7
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
            : base(new FlyWithWings(), new DuckQuack(), new Swim_())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Рыжая утка:");
            base.Display();
        }
    }
}
