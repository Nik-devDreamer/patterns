using System;

namespace Program.Quack
{
    public class DuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Утка крякает");
        }
    }
}