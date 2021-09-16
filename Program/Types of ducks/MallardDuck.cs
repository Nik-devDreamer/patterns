using System;
using Program.Swimable;
using Program.Fly;
using Program.Quack;

namespace Program
{
    class MallardDuck : Duck
    {
        public MallardDuck()
            : base(new FlyWithWings(), new DuckQuack(), new Swim_())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Крякающая утка:");
            base.Display();
        }
    }
}