using System;

namespace Program.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Данная утка не умеет летать");
        }
    }
}