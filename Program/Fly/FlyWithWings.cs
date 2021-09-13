using System;

namespace Program.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Утка летит");
        }
    }
}