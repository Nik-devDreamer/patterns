using System;
using Program.Swimable;
using Program.Fly;
using Program.Quack;

namespace Program
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
        private ISwim _swim;

        public Duck(IFlyBehavior fly, IQuackBehavior quack, ISwim swim)
        {
            _flyBehavior = fly;
            _quackBehavior = quack;
            _swim = swim;
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            _swim.Swim();
        }

        public void Dead()
        {
            Console.WriteLine("Утка мертва");
            _flyBehavior = new FlyNoWay();
            _swim = new NoSwim();
            _quackBehavior = new NoQuack();
        }

        public void Display()
        {
            _flyBehavior.Fly();
            _quackBehavior.Quack();
            _swim.Swim();
        }
    }
}