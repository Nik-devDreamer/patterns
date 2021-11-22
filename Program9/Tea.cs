using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program9
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brew tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add sugar");
        }
    }
}
