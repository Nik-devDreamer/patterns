using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program7.Swimable;
using Program7.Fly;
using Program7.Quack;

namespace Program7
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
            : base(new FlyNoWay(), new NoQuack(), new Swim_())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Ложная утка:");
            base.Display();
        }
    }
}
