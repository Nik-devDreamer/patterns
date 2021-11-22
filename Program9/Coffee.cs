using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program9
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brew coffee");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add milk");
        }
    }
}
