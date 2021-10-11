using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program4.Cheese;
using Program4.Clams;
using Program4.Dough;
using Program4.Pepperoni;
using Program4.Sauce;
using Program4.Veggies;

namespace Program4.pizza
{
    public abstract class Pizza
    {
        public string Name;
        public IDough Dough;
        public ISauce Sauce;
        public IPepperoni Pepperoni;
        public ICheese Cheese;
        public IClams Clams;

        public List<IVeggies> Veggies = new List<IVeggies>();

        public abstract string Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking for 15 minutes");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
    }
}
