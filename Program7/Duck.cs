using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program7.Swimable;
using Program7.Fly;
using Program7.Quack;

namespace Program7
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

        public virtual void Display()
        {
            _flyBehavior.Fly();
            _quackBehavior.Quack();
            _swim.Swim();
        }
    }
}
