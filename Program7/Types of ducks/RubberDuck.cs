using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program7.Swimable;
using Program7.Fly;
using Program7.Quack;

namespace Program7
{
    class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new FlyNoWay(), new RubberDuckQuack(), new Swim_())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Резиновая утка:");
            base.Display();
        }
    }
}
