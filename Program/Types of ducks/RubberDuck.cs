using System;
using Program.Swimable;
using Program.Fly;
using Program.Quack;

namespace Program
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