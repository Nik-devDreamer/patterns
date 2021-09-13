using System;

namespace Program.Quack
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Данная утка не крякает");
        }
    }
}