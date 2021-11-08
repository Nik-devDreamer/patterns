using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program7.Quack
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Утка не крякает");
        }
    }
}
