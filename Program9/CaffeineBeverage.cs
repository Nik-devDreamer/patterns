using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program9
{
    public abstract class CaffeineBeverage
    {
        private static void BoilWater()
        {
            Console.WriteLine("Boil water");
        }

        private static void PourInCap()
        {
            Console.WriteLine("Pour in cap");
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void PrepareRecipe()
        {
            BoilWater();
            PourInCap();
            Brew();
            AddCondiments();
        }
    }
}
