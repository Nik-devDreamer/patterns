using System;

namespace Program.Quack
{
    public class RubberDuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Резиновая утка крякает");
        }
    }
}