using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Program3.Drink;
using Program3.Condiment;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine("{0} = {1}$", beverage.GetDescription(), beverage.Cost());
            beverage = new Decaf();
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            Console.WriteLine("{0} = {1}$", beverage.GetDescription(), beverage.Cost());
            Console.ReadKey();
        }
    }
}